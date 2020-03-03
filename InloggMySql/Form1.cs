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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();
            {

                /*Att göra

                *Hämta data från användaren och spara uppgifter.

                *Möjlighet att ändra lösenord på konto UPDATE.

                *Dynamiskt hämta konton, alla inlogg kan ju ha olika mängd bankkonton,
                 vi vill kunna se dem konton som finns tillgängliga 


                */
            }

            string query = "SELECT * FROM banktest.användare Where användarnamn = "+textBox1.Text+"";

            DBConnection dbcon = DBConnection.Instance();

            if (dbcon.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, dbcon.Connection);

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    
                }

                /*if (reader.HasRows)
                {
                    reader.Read();
                    Program.användare = new Användare(reader.GetString("användarnamn"), reader.GetString("password"),
                        reader.GetString("namn"), reader.GetString("adress"));

                    Inloggad form = new Inloggad();

                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(query + "funkade inte");
                }
                */
                reader.Close();
            }
        }

       

        
    }
}
