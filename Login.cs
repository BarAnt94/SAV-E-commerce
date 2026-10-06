using System;
using System.Data.SQLite;

internal class Login
{
    protected bool isAuthenticated = false;
    private readonly string _connectionString;

    public string password { get; private set; }
    public bool IsAuthenticated => isAuthenticated;
    public Login(string connectionString)
	{
        _connectionString = connectionString;
	}
    public void AuthenticateUser(string username, string password)
    {
        using var connection = new SQLiteConnection(_connectionString);
        connection.Open();
        string sql = "SELECT password FROM User WHERE username = @username";
        using (var command = new SQLiteCommand(sql, connection))
        {
            command.Parameters.AddWithValue("@username", username);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isAuthenticated = false;
                return;
            }
            var result = command.ExecuteScalar();
            if (result == null)
            {
                MessageBox.Show("Nom d'utilisateur introuvable.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isAuthenticated = false;
                return;
            }
            string passwordHash = result.ToString();
            if (BCrypt.Net.BCrypt.Verify(password, passwordHash))
            {
                isAuthenticated = true;
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isAuthenticated = false;
            }
        }
        connection.Close();
    }

    public void Inscription(string username, string email, string phone, string password,string confirmPassword)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
        {
            MessageBox.Show("Veuillez remplir tous les champs.", "Mauvaise saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (confirmPassword != password)
        {
            MessageBox.Show("Les mots de passe ne correspondent pas.", "Mauvaise saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        using var connection = new SQLiteConnection(_connectionString);
        connection.Open();
        string sql = "INSERT INTO User (username, email, telephone, password) VALUES (@username, @email, @telephone, @password)";
        using (var command = new SQLiteCommand(sql, connection))
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@telephone", phone);
            command.Parameters.AddWithValue("@password", passwordHash);
            command.ExecuteNonQuery();
        }
        isAuthenticated = true;
        connection.Close();
        MessageBox.Show("Inscription réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
