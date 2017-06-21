using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIP
{
    public partial class DodajAwatar : Form
    {
        private int UserID = Logowanie.return_UserID();
        public DodajAwatar()
        {
            InitializeComponent();
        }

        private void bt_SprawdzAvatar_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(tb_url.Text.ToString(), UriKind.RelativeOrAbsolute) == true)
            {
                WczytajAvatar(tb_url.Text.ToString());
            }
            else
            {
                MessageBox.Show("Niepoprawny adres");

            }
        }
        private void WczytajAvatar(string Url)
        {
            if (Url != String.Empty)
            {
                WebRequest request = WebRequest.Create(Url);
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {

                        pb_dodawanyAvatar.Image = Bitmap.FromStream(str);
                        pb_dodawanyAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                }
            }
        }

        private void bt_rejestracja_Click(object sender, EventArgs e)
        {
            this.Hide();
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

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Update Users Set AvatarPath='" + tb_url.Text.ToString() + "' WHERE UserID='"+ UserID + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pomyslnie dodano Avatar, zrestartuj program aby zobaczyć zmiany");
                    con.Close();
                    this.Hide();
                }
            }
        }
    }
}
