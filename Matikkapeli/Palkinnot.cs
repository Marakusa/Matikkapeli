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
    public partial class Palkinnot : Form
    {
        public Palkinnot()
        {
            InitializeComponent();

            List<int> trophiesAchieved = new List<int>();
            listView1.Clear();

            using (SqlConnection connection = new SqlConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"SELECT * FROM [Trophies];", connection);
                    //int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = reader["Name"].ToString();
                            item.ToolTipText = reader["Desc"].ToString();
                            item.StateImageIndex = int.Parse(reader["Icon"].ToString()) * 2;
                            listView1.Items.Add(item);
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe yhdistäessä tietokantaan:\n" + ex.Message);
                }

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand($"SELECT * FROM [User_Trophies] WHERE [User_id] = " + Program.login.user_id + ";", connection);
                    //int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            trophiesAchieved.Add(int.Parse(reader["Trophy_id"].ToString()));
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe yhdistäessä tietokantaan:\n" + ex.Message);
                }
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (!trophiesAchieved.Contains(i))
                {
                    listView1.Items[i].Text += " (Lukittu)";
                    listView1.Items[i].StateImageIndex += 1;
                }
            }
        }
    }
}
