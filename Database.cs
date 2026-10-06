using System;
using System.Data.SQLite;

internal class Database
{
	private string _connectionString;

	public Database(string connectionString)
	{
        _connectionString = connectionString;
    }
    public static void ConnectToDatabase()
    {
        string databasePath = "C:\\sqlite\\SQLiteDatabaseBrowserPortable\\SAV_ecommerce.sqlite";
        string connectionString = $"Data Source={databasePath};Version=3;";
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            MessageBox.Show("Connected to the database successfully!");
        }
        
    }
}
