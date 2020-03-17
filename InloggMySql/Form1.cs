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
            Program.konton = new List<Konto>();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {

                /*Att göra
                 
                *Hämta data från användaren och spara uppgifter. KLAR

                *Möjlighet att ändra lösenord på konto UPDATE. KLAR

                *Dynamiskt hämta konton, alla inlogg kan ju ha olika mängd bankkonton,
                 vi vill kunna se dem konton som finns tillgängliga - Klar

                *Registrering av användarkonto INSERT - Klar

                *Uppritning av konton i vyn - Att göra!




                */
            }

            string query = "SELECT * FROM användare WHERE användarnamn = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";

            DBConnection dBConnection = DBConnection.Instance();

            if (dBConnection.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Inloggad");

                    reader.Read();
                    Program.user = new Användare(reader.GetString("användarnamn"), reader.GetString("password"), reader.GetString("namn"), reader.GetString("adress"));

                    reader.Close();

                    InloggadForm nyruta = new InloggadForm();
                    this.Hide();
                    nyruta.Show();



                }
                else
                {
                    MessageBox.Show("Fel uppgifter");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RegistreraForm ruta = new RegistreraForm();
            ruta.Show();
        }


        
    }
}
