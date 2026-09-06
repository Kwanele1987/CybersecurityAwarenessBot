using MySql.Data.MySqlClient;
using CybersecurityAwarenessBot.Models;

namespace CybersecurityAwarenessBot.Services;

public class MySqlTaskRepository
{
    // Change these values to match your local MySQL installation.
    private const string Server = "localhost";
    private const string Database = "cybersecurity_bot";
    private const string User = "root";
    private const string Password = "Kwanele1987%";

    private string ServerConnectionString =>
        $"Server={Server};User ID={User};Password={Password};SslMode=None;";

    private string DatabaseConnectionString =>
        $"{ServerConnectionString}Database={Database};";

    public async Task EnsureDatabaseAndTableAsync()
    {
        await using (var connection = new MySqlConnection(ServerConnectionString))
        {
            await connection.OpenAsync();
            await using var command = connection.CreateCommand();
            command.CommandText = $"CREATE DATABASE IF NOT EXISTS `{Database}`;";
            await command.ExecuteNonQueryAsync();
        }

        await using (var connection = new MySqlConnection(DatabaseConnectionString))
        {
            await connection.OpenAsync();
            await using var command = connection.CreateCommand();
            command.CommandText = """
                CREATE TABLE IF NOT EXISTS tasks (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    title VARCHAR(150) NOT NULL,
                    description VARCHAR(500) NOT NULL,
                    reminder_date DATE NULL,
                    is_completed BOOLEAN NOT NULL DEFAULT FALSE,
                    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
                );
                """;
            await command.ExecuteNonQueryAsync();
        }
    }

    public async Task<List<CyberTask>> GetTasksAsync()
    {
        var result = new List<CyberTask>();

        await using var connection = new MySqlConnection(DatabaseConnectionString);
        await connection.OpenAsync();

        await using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT id, title, description, reminder_date, is_completed
            FROM tasks
            ORDER BY is_completed, reminder_date IS NULL, reminder_date, id DESC;
            """;

        await using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            result.Add(new CyberTask
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Title = reader.GetString(reader.GetOrdinal("title")),
                Description = reader.GetString(reader.GetOrdinal("description")),
                ReminderDate = reader.IsDBNull(reader.GetOrdinal("reminder_date"))
    ? null
    : reader.GetDateTime(reader.GetOrdinal("reminder_date")),
                IsCompleted = reader.GetBoolean(reader.GetOrdinal("is_completed"))
            });
        }

        return result;
    }

    public async Task AddTaskAsync(CyberTask task)
    {
        await using var connection = new MySqlConnection(DatabaseConnectionString);
        await connection.OpenAsync();

        await using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO tasks (title, description, reminder_date, is_completed)
            VALUES (@title, @description, @reminder, FALSE);
            """;

        command.Parameters.AddWithValue("@title", task.Title);
        command.Parameters.AddWithValue("@description", task.Description);
        command.Parameters.AddWithValue("@reminder", task.ReminderDate?.Date);

        await command.ExecuteNonQueryAsync();
    }

    public async Task MarkCompletedAsync(int id)
    {
        await using var connection = new MySqlConnection(DatabaseConnectionString);
        await connection.OpenAsync();

        await using var command = connection.CreateCommand();
        command.CommandText = "UPDATE tasks SET is_completed = TRUE WHERE id = @id;";
        command.Parameters.AddWithValue("@id", id);
        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteTaskAsync(int id)
    {
        await using var connection = new MySqlConnection(DatabaseConnectionString);
        await connection.OpenAsync();

        await using var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM tasks WHERE id = @id;";
        command.Parameters.AddWithValue("@id", id);
        await command.ExecuteNonQueryAsync();
    }
}
