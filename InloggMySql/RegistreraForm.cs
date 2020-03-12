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
    public partial class RegistreraForm : Form
    {
        public RegistreraForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `banktest`.`användare` (`användarnamn`, `password`, `namn`, `adress`) VALUES ('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"');";

            DBConnection dbcon = DBConnection.Instance();

            if (dbcon.IsConnect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.Connection);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Användaren har registrerats!");
                    this.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Användarnamnet finns redan!");
                }
            }
        }
    }
}
