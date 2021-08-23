using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;

namespace Matikkapeli
{
    public partial class LogIn : Form
    {
        string connectionString = "";

        public int user_id = 0;

        public LogIn()
        {
            InitializeComponent();

            connectionString = Program.connectionString;

            user_id = 0;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInUser(tunnus.Text, salasana.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register(regTunnus.Text, regSalasana.Text);
        }

        private void Connect()
        {
            bool quit = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    tunnus.Text = Properties.Settings.Default.username;
                    salasana.Text = Properties.Settings.Default.password;

                    if (tunnus.Text != "" && salasana.Text != "")
                        LogInUser(tunnus.Text, salasana.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to database: " + ex.Message);
                    quit = true;
                }

                connection.Close();
            }

            if (quit)
                Application.Exit();
        }

        private void LogInUser(string username, string password)
        {
            user_id = 0;
            bool loggedIn = false;

            button1.Enabled = false;
            button2.Enabled = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"SELECT * FROM [Users] WHERE Username=@u;", connection);
                    command.Parameters.AddWithValue("@u", username);
                    //int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user_id = (int)reader["Id"];
                            string _username = (string)reader["Username"];
                            string _password = (string)reader["Password"];

                            string _hash = "";
                            using (SHA512 shaM = new SHA512Managed())
                            {
                                _hash = Encoding.UTF8.GetString(shaM.ComputeHash(Encoding.UTF8.GetBytes(password)));
                            }

                            if (_password == _hash)
                            {
                                Properties.Settings.Default.username = tunnus.Text;
                                Properties.Settings.Default.password = salasana.Text;
                                Properties.Settings.Default.Save();

                                Program.OpenMain(_username);
                                loggedIn = true;
                            }
                            else
                                MessageBox.Show("Tarkista salasana");
                        }
                        else
                            MessageBox.Show("Käyttäjää ei löydetty");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe yhdistäessä tietokantaan:\n" + ex.Message);
                }

                connection.Close();
            }

            button1.Enabled = true;
            button2.Enabled = true;

            if (loggedIn)
                Hide();
        }
        private void Register(string username, string password)
        {
            user_id = 0;
            button1.Enabled = false;
            button2.Enabled = false;

            if (username.Length >= 3 && password.Length >= 8 && Regex.Match(username, "^[a-zA-Z0-9_]*$").Success
                && username.Length <= 20 && password.Length <= 50)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string _hash = "";
                        using (SHA512 shaM = new SHA512Managed())
                        {
                            _hash = Encoding.UTF8.GetString(shaM.ComputeHash(Encoding.UTF8.GetBytes(password)));
                        }

                        SqlCommand command = new SqlCommand($"INSERT INTO [Users](Username, Password) VALUES (@u, @p);", connection);
                        command.Parameters.AddWithValue("@u", username);
                        command.Parameters.AddWithValue("@p", _hash);
                        //int result = command.ExecuteNonQuery();
                        command.ExecuteScalar();
                        MessageBox.Show("Rekisteröinti onnistui.");

                        tunnus.Text = username;
                        salasana.Text = password;
                        LogInUser(username, password);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tapahtui virhe yhdistäessä tietokantaan:\n" + ex.Message);
                    }

                    connection.Close();
                }
            }
            else
                MessageBox.Show("Käyttäjätunnus tai salasana liian lyhyt.\nKäyttäjätunnuksen täytyy olla 3-20 merkkiä pitkä\nja voi sisältää vain (a-z A-Z 0-9 ja _).");

            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
