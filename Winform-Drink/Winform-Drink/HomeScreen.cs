using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Winform_Drink
{
    public partial class HomeScreen : Form
    {
        public HomeScreen(string pin)
        {
            InitializeComponent();
            getUserInfo(pin);
        }

        private void getUserInfo(string pin)
        {
            string query = "SELECT Fname, Lname FROM Users WHERE Pin = '" + pin + "';";
            DataTable info = new DataTable();
            var connection = ConnectionFactory.Create();
            MySqlDataAdapter datacmd = new MySqlDataAdapter(query, connection);
            datacmd.Fill(info);
            connection.Close();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                DataRow row = info.Rows[i];
                userbtn.Text = row["Fname"] + " " + row["Lname"] + "'s tab info";
            }
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            UserTab user = new UserTab();
            this.Hide();
            var display = user.ShowDialog();
        }
    }
}
