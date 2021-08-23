using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class Nopeustesti : Form
    {
        private int countdown = 3;

        private int time = 60;

        private float difficulty = 1f;
        private bool canAnswer = false;
        private double rightAnswer = 0;

        private int calculations = 0;

        private string connectionString = "";

        public Nopeustesti()
        {
            InitializeComponent();

            connectionString = Program.connectionString;

            answer.Enabled = false;
            LoadHighscores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartGame()
        {
            calculations = 0;
            button1.Visible = false;
            countdown = 3;
            toCalculate.Text = countdown.ToString();
            countdownTimer.Enabled = true;
        }
        private void CountdownEnd()
        {
            countdownTimer.Enabled = false;
            toCalculate.Text = "...";
            countdown = 3;
            answer.Enabled = true;
            answer.Select();

            timer1.Enabled = true;

            GenerateCalculation(difficulty);
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            countdown--;
            toCalculate.Text = countdown.ToString();

            if (countdown <= 0)
            {
                CountdownEnd();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time -= 1;

            if (time > 0)
            {
                timeText.Text = time.ToString();
            }
            else
            {
                answer.Enabled = false;
                timer1.Enabled = false;

                timeText.Text = "Aika! Tuloksesi on " + ((float)calculations / 60f * 100f).ToString("0.00") + " pistettä";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        float points = ((float)calculations / 60f * 100f);

                        SqlCommand command = new SqlCommand($"INSERT INTO [Points](User_id, Points, Time) VALUES (@u, @p, @t);", connection);
                        command.Parameters.AddWithValue("@u", Program.login.user_id);
                        command.Parameters.AddWithValue("@p", points);
                        command.Parameters.AddWithValue("@t", DateTime.Now);
                        //int result = command.ExecuteNonQuery();
                        command.ExecuteScalar();

                        connection.Close();

                        List<int> trophiesAchieved = new List<int>();

                        connection.Open();

                        SqlCommand commandT = new SqlCommand($"SELECT * FROM [User_Trophies] WHERE [User_id] = " + Program.login.user_id + ";", connection);
                        //int result = command.ExecuteNonQuery();
                        using (SqlDataReader reader = commandT.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trophiesAchieved.Add(int.Parse(reader["Trophy_id"].ToString()));
                            }
                        }

                        connection.Close();

                        if (points >= 40f && !trophiesAchieved.Contains(1))
                        {
                            Achieve(1);
                        }
                        if (points >= 50f && !trophiesAchieved.Contains(2))
                        {
                            Achieve(2);
                        }
                        if (points >= 60f && !trophiesAchieved.Contains(3))
                        {
                            Achieve(3);
                        }

                        timeText.Text += "\nPisteiden lähetys onnistui.";
                        LoadHighscores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tapahtui virhe yhdistäessä tietokantaan:\n" + ex.Message);
                    }
                }
            }
        }

        private void GenerateCalculation(float difficulty)
        {
            canAnswer = false;

            Random random = new Random();

            float answer = 0;

            int parameter1 = 0;
            int parameter2 = 0;
            int type = 0;

            if (difficulty < 5f)
                type = random.Next(0, 1);
            else
                type = random.Next(0, 2);

            parameter1 = random.Next(1, 1 + (int)Math.Round(1.5 * (difficulty / (type + 1))));
            parameter2 = random.Next(1, 1 + (int)Math.Round(1.5 * (difficulty / (type + 1))));

            switch (type)
            {
                case 0:
                    answer = parameter1 + parameter2;
                    toCalculate.Text = $"{parameter1} + {parameter2}";
                    break;
                case 1:
                    answer = parameter1 - parameter2;
                    toCalculate.Text = $"{parameter1} - {parameter2}";
                    break;
                case 2:
                    answer = parameter1 * parameter2;
                    toCalculate.Text = $"{parameter1} * {parameter2}";
                    break;
            }

            rightAnswer = answer;
            this.answer.Text = "";
            canAnswer = true;
        }

        private void answer_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(answer.Text, out double ans) && canAnswer)
            {
                if (ans == rightAnswer)
                {
                    calculations++;
                    difficulty += 1f;
                    GenerateCalculation(difficulty);
                }
            }
        }

        private void LoadHighscores()
        {
            highscores.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                bool topScore = false;

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"SELECT * FROM [Points] INNER JOIN [Users] ON [Points].User_id = [Users].Id ORDER BY [Points].Points DESC;", connection);
                    //int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            if (i == 0 && int.Parse(reader["User_id"].ToString()) == Program.login.user_id)
                                topScore = true;

                            highscores.Items.Add(reader["Username"] + " - " + float.Parse(reader["Points"].ToString()).ToString("0.00"));
                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe yhdistäessä tietokantaan:\n" + ex.Message);
                }

                connection.Close();

                if (topScore)
                {
                    List<int> trophiesAchieved = new List<int>();

                    connection.Open();

                    SqlCommand commandT = new SqlCommand($"SELECT * FROM [User_Trophies] WHERE [User_id] = " + Program.login.user_id + ";", connection);
                    //int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = commandT.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            trophiesAchieved.Add(int.Parse(reader["Trophy_id"].ToString()));
                        }
                    }

                    connection.Close();

                    if (!trophiesAchieved.Contains(0))
                    {
                        Achieve(0);
                    }
                }
            }
        }

        private void Achieve(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command2 = new SqlCommand($"INSERT INTO [User_Trophies](Trophy_id, User_id, Time) VALUES (@t, @u, @i);", connection);
                command2.Parameters.AddWithValue("@t", id);
                command2.Parameters.AddWithValue("@u", Program.login.user_id);
                command2.Parameters.AddWithValue("@i", DateTime.Now);
                //int result = command.ExecuteNonQuery();
                command2.ExecuteScalar();

                connection.Close();

                connection.Open();

                SqlCommand commandRead = new SqlCommand($"SELECT * FROM [Trophies] WHERE [Id] = " + id.ToString() + ";", connection);
                //int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = commandRead.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Sait saavutuksen!\n" + reader["Name"].ToString());
                    }
                }

                connection.Close();
            }
        }
    }
}
