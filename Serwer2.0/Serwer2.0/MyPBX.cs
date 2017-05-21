using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ozeki.Network;
using Ozeki.VoIP;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Serwer2._0
{
    class MyPBX : PBXBase
    {
        string localAddress;
        Main SG = new Main();
        public MyPBX(string localAddress, int minPortRange, int maxPortRange) : base(minPortRange, maxPortRange)
        {
            this.localAddress = localAddress;
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
                    cmd.CommandText = ("UPDATE Rooms SET IPAdres='"+ localAddress.ToString()+ "' WHERE RoomID=1");
                    cmd.ExecuteNonQuery();


                }
            }
                
            SG.konsola_pisz("PBX starting...\n");
            SG.konsola_pisz("Local address: " + localAddress.ToString() + "\n");
        }

        protected override void OnStart()
        {
            SetListenPort(localAddress, 5060, TransportType.Udp);
            SG.konsola_pisz("Listened port: 5060(UDP)\n");
            SG.konsola_pisz("PBX started.\n");
            base.OnStart();
        }

        protected override RegisterResult OnRegisterReceived(ISIPExtension extension, SIPAddress from, int expires)
        {
           // SG.konsola_pisz("Register received from: " + extension.ExtensionID.ToString() + "\n");
            return base.OnRegisterReceived(extension, from, expires);
        }

        protected override void OnUnregisterReceived(ISIPExtension extension)
        {
           // SG.konsola_pisz("Unregister received from: " + extension.ExtensionID.ToString() + "\n");
            base.OnUnregisterReceived(extension);
        }

        protected override void OnCallRequestReceived(ISessionCall call)
        {
            //SG.konsola_pisz("Call request received. Caller: " + call.DialInfo.CallerID.ToString() + " callee: " + call.DialInfo.Dialed.ToString() + "\n");
            base.OnCallRequestReceived(call);
        }
        public void gui_start()
        {
            Application.Run(SG);
        }
    }
}
