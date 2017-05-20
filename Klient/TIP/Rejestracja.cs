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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
            Error_Haslo.Visible = false;
            Error_Nick.Visible = false;
            Error_mail.Visible = false;
            Error_BHaslo.Visible = false;
            Error_NMail.Visible = false;
        }
        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {

                return false;
            }
        }

        private void bt_LogIn_Click(object sender, EventArgs e)
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

                    if (IsValidEmail(tb_Mail.Text) == false)
                    {
                        Error_NMail.Visible = true;
                        return;
                    }
                    else
                    {
                        Error_NMail.Visible = false;
                    }

                    if (con.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Problem z nawiązaniem połączenia z bazą danych.", "Błąd systemu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bool daneOK = true;
                    DataTable data = new DataTable();
                    
                    SqlDataAdapter sda0 = new SqlDataAdapter("Select Count(CASE WHEN Nick='"+tb_Nick.Text+"' Then 1 Else NULL END),Count(CASE WHEN Email='"+tb_Mail.Text+"' Then 1 Else NULL END) From Users", con);
                    sda0.Fill(data);
                    if (data.Rows[0][0].ToString() != "0")
                    {
                        tb_Nick.Clear();
                        Error_Nick.Visible = true;
                        daneOK = false;
                    }
                    else
                    {
                        Error_Nick.Visible = false;
                        daneOK = true;
                    }

                    if (data.Rows[0][1].ToString() != "0")
                    {
                        tb_Mail.Clear();
                        Error_mail.Visible = true;
                        daneOK = false;
                    }
                    else
                    {
                        Error_mail.Visible = false;
                        daneOK = true;
                    }

                    if(tb_Haslo.Text != tb_PHaslo.Text )
                    {
                        tb_Haslo.Clear();
                        tb_PHaslo.Clear();
                        Error_Haslo.Visible = true;
                        daneOK = false;
                        

                    }
                    else
                    {
                        Error_Haslo.Visible = false;
                        daneOK = true;
                    }

                    if(tb_PHaslo.Text==String.Empty || tb_Nick.Text ==String.Empty || tb_Mail.Text == String.Empty || tb_PHaslo.Text==String.Empty)
                    {
                        Error_BHaslo.Visible = true;
                        daneOK = false;
                    }
                    else
                    {
                        Error_BHaslo.Visible = false;
                        daneOK = true;
                    }
                    if(daneOK==true)
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = ("INSERT INTO Users(Nick,Email,Password) Values('" + tb_Nick.Text + "','" + tb_Mail.Text + "','" + tb_Haslo.Text + "');");
                        cmd.ExecuteNonQuery();
                        data.Clear();
                        MessageBox.Show("Pomyslnie dodano użytkownika: " + tb_Nick.Text);

                        
                        Logowanie Log = new Logowanie();
                        this.Hide();
                        Log.Show();
                    }
                    else
                    {
                        
                        data.Clear();
                    }
                }
                else MessageBox.Show("Blad sieci");
            }
        }

        private void bt_rejestracja_Click(object sender, EventArgs e)
        {
            Logowanie Log = new Logowanie();
            this.Hide();
            Log.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
