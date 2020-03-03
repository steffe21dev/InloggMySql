using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InloggMySql
{
    public partial class Inloggad : Form
    {
        public Inloggad()
        {
            InitializeComponent();

            label1.Text = Program.användare.namn.ToString();
            label2.Text = Program.användare.adress.ToString();
            label3.Text = Program.användare.användarnamn.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE banktest.användare SET password = '"+textBox1.Text+"' WHERE (användarnamn = '"+Program.användare.användarnamn+"');";

            DBConnection dBConnection = DBConnection.Instance();

            if (dBConnection.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lösenord bytt!");
            }
        }
    }
}
