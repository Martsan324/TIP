using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TIP
{
    public partial class DodajZnajomych : Form
    {
        private int UserID = Logowanie.return_UserID();
        private int friendID;
        DataTable friends = new DataTable();
        public DodajZnajomych()
        {
            InitializeComponent();
        }

        private void bt_rejestracja_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            friends.Clear();
            using (SqlConnection con = new SqlConnection(@"Server=tcp:tipserwer.database.windows.net;Database=TIP;
                                                           User ID=martsan;Password=Tiptip123;Trusted_Connection=False;Encrypt=True;"))
            {
                bool polaczenie = true;
                try
                {
                    con.Open();
                }
                catch (Exception blad_sieci)
                {

                    polaczenie = false;
                };
                bool dostep = true;
                bool istnieje = true;

                if (polaczenie == true)
                {


                    if (con.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Problem z nawiązaniem połączenia z bazą danych.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    int temp = 0;
                    Int32.TryParse(tb_szukaj.Text.ToString(), out temp);
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT UserID, Nick From Users Where UserID='"+ temp + "' OR Nick ='"+ tb_szukaj.Text.ToString() + "'", con);
                    sd.Fill(friends);
                    if (friends.Rows.Count == 0)
                    {
                        MessageBox.Show("Brak wyniku :(");
                    }
                    else
                    {
                        listBox1.Items.Add(friends.Rows[0][1].ToString());
                    }
                }

            }
        }
        private void DodajZnajomych_Load(object sender, EventArgs e)
        {

        }

        private void bt_Zarejestruj_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Server=tcp:tipserwer.database.windows.net;Database=TIP;
                                                           User ID=martsan;Password=Tiptip123;Trusted_Connection=False;Encrypt=True;"))
            {
                bool polaczenie = true;
                try
                {
                    con.Open();
                }
                catch (Exception blad_sieci)
                {

                    polaczenie = false;
                };
                bool dostep = true;
                bool istnieje = true;

                if (polaczenie == true)
                {


                    if (con.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Problem z nawiązaniem połączenia z bazą danych.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    for (int i = 0; i < friends.Rows.Count; i++)
                    {
                        if (friends.Rows[i][1].ToString() == listBox1.SelectedItem.ToString())
                        {
                            Int32.TryParse(friends.Rows[i][0].ToString(), out friendID);
                        }
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Insert INTO Contacts (ID_Wlasciciela,ID_kontaktu) Values (" + UserID + "," + friendID + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyslnie dodano użytkownika o ID: " + friendID);
                    con.Close();
                    this.Hide();
                }
            }
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
