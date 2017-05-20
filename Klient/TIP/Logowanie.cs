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
using System.Security.Cryptography;
namespace TIP
{
    public partial class Logowanie : Form
    {
        public static int UserID;
        public Logowanie()
        {   
            InitializeComponent();
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
        //blabla
        private void connect()
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

                    // SPRAWDZENIE LOGINU I HASLA JEDNOCZEŚNIE
                    DataTable data = new DataTable();
                    SqlDataAdapter sda0 = new SqlDataAdapter("SELECT Count(*) FROM Users WHERE Nick='" + tb_login.Text + "' AND Password='" + tb_haslo.Text + "'", con);
                    sda0.Fill(data);
                    if (data.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("Podano błędne dane logowania.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dostep = false;
                        istnieje = false;
                        tb_login.Clear();
                        tb_haslo.Clear();
                    }
                    data.Clear();
                    if (dostep == true)
                    {
                        DataTable data1 = new DataTable();
                        SqlDataAdapter sd1 = new SqlDataAdapter("SELECT UserID From Users Where Nick='" + tb_login.Text+"'",con);
                        sd1.Fill(data1);
                        int temp=0;
                        Int32.TryParse(data1.Rows[0][0].ToString(),out temp);
                        UserID = temp;

                        Main main = new Main();
                        this.Hide();
                        main.Show();
                        con.Close();
                    }

                }
                else MessageBox.Show("Blad sieci");
            }
        }

        
        private void bt_LogIn_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void bt_rejestracja_Click(object sender, EventArgs e)
        {
            
            Rejestracja rej = new Rejestracja();
            this.Hide();
            rej.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal static int return_UserID()
        {
            return UserID;
        }
    }
}
