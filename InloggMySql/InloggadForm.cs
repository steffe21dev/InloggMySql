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
    public partial class InloggadForm : Form
    {
        public InloggadForm()
        {
            InitializeComponent();

            label1.Text = Program.user.användarnamn;
            label2.Text = Program.user.namn;
            label3.Text = Program.user.adress;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE  användare SET password = '"+textBox1.Text+"' WHERE (användarnamn = '"+Program.user.användarnamn+"');";
            DBConnection dBConnection = DBConnection.Instance();

            if (dBConnection.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Bytt lösen!");
                textBox1.Clear();
            }
        }
    }
}
