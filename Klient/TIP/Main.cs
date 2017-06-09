using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ozeki.Media.MediaHandlers;
using Ozeki.VoIP;
using Ozeki.VoIP.SDK;
using Ozeki.Network;
using System.Data.SqlClient;
using System.Net;

namespace TIP
{
    public partial class Main : Form
    {
        private int UserID = Logowanie.return_UserID();
        private string IPaddres;
        private string avatarPath;
        private DataTable kontakty = new DataTable();
        private DataTable RoomIP = new DataTable();
        private ISoftPhone softPhone;
        private IPhoneLine phoneLine;
        private RegState phoneLineInformation;
        private IPhoneCall call;
        private Microphone microphone = Microphone.GetDefaultDevice();
        private Speaker speaker = Speaker.GetDefaultDevice();
        MediaConnector connector = new MediaConnector();
        PhoneCallAudioSender mediaSender = new PhoneCallAudioSender();
        PhoneCallAudioReceiver mediaReceiver = new PhoneCallAudioReceiver();
        
        private bool inComingCall;
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lb_ID.Text = UserID.ToString();
            InitializeSoftPhone();
            WczytajKontakty(true);
            WczytajAvatar(avatarPath, true);
           
        }

        private void InitializeSoftPhone()
        {
            downloadIPAddres();
            try
            {

                softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(), 5700, 5750);
                InvokeGUIThread(() => { lb_Log.Items.Add("Softphone created!"); });
                
                softPhone.IncomingCall += new EventHandler<VoIPEventArgs<IPhoneCall>>(softPhone_inComingCall);

                SIPAccount sa = new SIPAccount(true, UserID.ToString(), UserID.ToString(), UserID.ToString(), UserID.ToString(), IPaddres, 5060);
                InvokeGUIThread(() => { lb_Log.Items.Add("SIP account created! - " + sa.RegisterName); });
                
                phoneLine = softPhone.CreatePhoneLine(sa);
                phoneLine.RegistrationStateChanged += phoneLine_PhoneLineInformation;
                InvokeGUIThread(() => { lb_Log.Items.Add("Phoneline created."); });
                softPhone.RegisterPhoneLine(phoneLine);


                ConnectMedia();
                //softPhone.UnregisterPhoneLine(phoneLine);
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Local IP error!"); });
            }

        }
        
        private void downloadIPAddres()
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
                    DataTable MyAvatar = new DataTable();
                    SqlDataAdapter sd = new SqlDataAdapter("Select IPAdres From Rooms WHERE RoomID=1", con);
                    SqlDataAdapter avatar = new SqlDataAdapter("Select AvatarPath From Users WHERE UserID='"+ UserID + "'", con);
                    sd.Fill(RoomIP);
                    avatar.Fill(MyAvatar);

                    IPaddres= RoomIP.Rows[0][0].ToString();
                    if (MyAvatar.Rows[0][0]!=null)
                    {
                        avatarPath = MyAvatar.Rows[0][0].ToString();
                    }

                }
            }
        }
        private void WczytajAvatar(string Url,bool user)
        {
            pb_my_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Url!=String.Empty)
            { 
                WebRequest request = WebRequest.Create(Url);
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        if (user == true)
                        {
                            pb_my_avatar.Image = Bitmap.FromStream(str);
                            pb_my_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else if (user == false)
                        {
                            pb_contact_avatar.Image = Bitmap.FromStream(str);
                            pb_contact_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }
           
        }
        private void WczytajKontakty(bool Online)
        {
           // listBox_kontakty.Items.Clear();
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
                    
                    SqlDataAdapter sd = new SqlDataAdapter("SELECT UserID,Nick,AvatarPath FROM Users where IsOnline='" + Online + "' AND UserID in (SELECT ID_kontaktu FROM Contacts C INNER JOIN Users U ON C.ID_Wlasciciela=U.UserID WHERE ID_Wlasciciela='" + UserID+"')", con);
                    sd.Fill(kontakty);
                    string temp;
                    for (int i = 0; i < kontakty.Rows.Count; i++)
                    {
                        //temp = kontakty.Rows[i][1].ToString() +" ID: "+ kontakty.Rows[i][0].ToString();
                        //listBox_kontakty.Items.Add(temp);
                        listBox_kontakty.Items.Add(kontakty.Rows[i][1].ToString());
                    }
                }
            }
        }

        private void StartDevices()
        {
            if (microphone != null)
            {
                microphone.Start();
                InvokeGUIThread(() => {lb_Log.Items.Add("Microphone Started."); });
            }
            if (speaker != null)
            {
                speaker.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Started."); });
            }
        }

        private void StopDevices()
        {
            if (microphone != null)
            {
                microphone.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Stopped."); });
            }
            if (speaker != null)
            {
                speaker.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Stopped."); });
            }
        }

        private void ConnectMedia()
        {
            if (microphone != null)
            {
                connector.Connect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Connect(mediaReceiver, speaker);
            }
        }
        private void DisconnectMedia()
        {
            if (microphone != null)
            {
                connector.Disconnect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Disconnect(mediaReceiver, speaker);
            }
        }

        private void InvokeGUIThread(Action action)
        {
            Invoke(action);
        }


        private void softPhone_inComingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Incoming call from: " + e.Item.DialInfo.ToString()); });
            btn_PickUp.Text = "Odbierz";
            btn_HangUp.Text = "Odrzuć";
            call = e.Item;
            WireUpCallEvents();
            inComingCall = true;
        }


        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {
            phoneLineInformation = e.State;

            InvokeGUIThread(() =>
            {
                if (phoneLineInformation == RegState.RegistrationSucceeded)
                {
                    lb_Log.Items.Add("Registration succeeded - Online");
                }
                else
                {
                    lb_Log.Items.Add("Not registered - Offline: " + phoneLineInformation.ToString());
                }
            });
        }


        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Callstate changed." + e.State.ToString()); });

            if (e.State == CallState.Answered)
            {
                StartDevices();

                mediaReceiver.AttachToCall(call);
                mediaSender.AttachToCall(call);

                InvokeGUIThread(() => { lb_Log.Items.Add("Call started."); });
            }

            if (e.State.IsCallEnded() == true)
            {
                StopDevices();

                mediaReceiver.Detach();
                mediaSender.Detach();

                WireDownCallEvents();

                call = null;

                InvokeGUIThread(() => { lb_Log.Items.Add("Call ended."); });
            }
        }


        private void WireUpCallEvents()
        {
            call.CallStateChanged += (call_CallStateChanged);
        }

        private void WireDownCallEvents()
        {
            call.CallStateChanged -= (call_CallStateChanged);
        }
        

        private void lb_Log_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_PickUp_Click(object sender, EventArgs e)
        {
            if (inComingCall)
            {
                inComingCall = false;
                call.Answer();
                btn_HangUp.Text = "Rozłacz się";
                InvokeGUIThread(() => { lb_Log.Items.Add("Call accepted."); });
                return;
            }

            if (call != null)
            {
                return;
            }

            if (phoneLineInformation != RegState.RegistrationSucceeded)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Registration Failed!"); });
                return;
            }

            call = softPhone.CreateCallObject(phoneLine,tb_Dzwon.Text);
            WireUpCallEvents();
            call.Start();
        }

        private void btn_HangUp_Click(object sender, EventArgs e)
        {
            if (call != null)
            {
                if (inComingCall && call.CallState == CallState.Ringing)
                {
                    btn_PickUp.Text = "Zadzwoń";
                    call.Reject();
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call rejected."); });
                }
                else
                {
                    btn_HangUp.Text = "Odrzuć";
                    call.HangUp();
                    inComingCall = false;
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call hanged up."); });
                }

                call = null;
            }           
        }

        private void Dzwon_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_kontakty_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < kontakty.Rows.Count; i++)
            {                
                if (listBox_kontakty.SelectedItem.ToString() == kontakty.Rows[i][1].ToString())
                {
                    tb_Dzwon.Text = kontakty.Rows[i][0].ToString();
                    
                    if (Uri.IsWellFormedUriString(kontakty.Rows[i][2].ToString(),UriKind.RelativeOrAbsolute) == true && kontakty.Rows[i][2].ToString() !=String.Empty)
                    {                 
                        WczytajAvatar(kontakty.Rows[i][2].ToString(), false);
                    }
                    else
                    {
                        pb_contact_avatar.Image = null;
                        
                    }

                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
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
                    cmd.CommandText = "Update Users set IsOnline=0 WHERE UserID='" + UserID + "';";
                    cmd.ExecuteNonQuery();
                }
                System.Windows.Forms.Application.Exit();
            }
        }

        private void cb_online_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_online.Checked == true)
            {
                kontakty.Clear();
                listBox_kontakty.Items.Clear();
                WczytajKontakty(false);
            }
            if (cb_online.Checked == false)
            {
                kontakty.Clear();
                listBox_kontakty.Items.Clear();

                WczytajKontakty(true);
                //WczytajKontakty(false);
            }
        }

        private void bt_szukaj_Click(object sender, EventArgs e)
        {
            DodajZnajomych dod = new DodajZnajomych();
            dod.Show();
        }

        private void pb_my_avatar_Click(object sender, EventArgs e)
        {
            DodajAwatar dod = new DodajAwatar();
            dod.Show();
        }
    }
   
}
