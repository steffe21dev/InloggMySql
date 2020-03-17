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
        static List<Konto> konton;
        public InloggadForm()
        {
            InitializeComponent();

            konton = new List<Konto>();
            Hämta_Konton();

            for (int i = 0; i < konton.Count; i++)
            {
                listView1.Items.Add("Kontonamn: " + konton[i].namn + " Saldo: " + konton[i].saldo);
                comboBox1.Items.Add(konton[i].namn);
            }


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

        static void Hämta_Konton()
        {
            string query = "SELECT * FROM banktest.konto where användarnamn = '" + Program.user.användarnamn + "';";

            DBConnection dBConnection = DBConnection.Instance();

            if (dBConnection.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, dBConnection.Connection);

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    konton.Add(new Konto(reader.GetInt16("idKonto"), reader.GetString("namn"), reader.GetDouble("saldo"), reader.GetString("användarnamn")));
                }

                reader.Close();



            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
