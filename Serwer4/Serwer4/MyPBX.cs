using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ozeki.Network;
using Ozeki.VoIP;
using System.Data.SqlClient;
using System.Data;


namespace Serwer4
{
    class MyPBX : PBXBase
    {
        string localAddress;

        public MyPBX(string localAddress, int minPortRange, int maxPortRange) : base(minPortRange, maxPortRange)
        {
            this.localAddress = localAddress;
            Console.WriteLine("PBX starting...\n");
            Console.WriteLine("Local address: " + localAddress.ToString() + "\n");
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
                        Console.WriteLine("Problem z nawiązaniem połączenia z bazą danych.");
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = ("UPDATE Rooms SET IPAdres='" + localAddress.ToString() + "' WHERE RoomID=1");
                    cmd.ExecuteNonQuery();

                }
            }


        }

        protected override void OnStart()
        {
            SetListenPort(localAddress, 5060, TransportType.Udp);
            Console.WriteLine("Listened port: 5060(UDP)\n");
            Console.WriteLine("PBX started.\n");
            base.OnStart();
        }

        protected override RegisterResult OnRegisterReceived(ISIPExtension extension, SIPAddress from, int expires)
        {
            Console.WriteLine("Register received from: " + extension.ExtensionID.ToString() + "\n");
            return base.OnRegisterReceived(extension, from, expires);
        }

        protected override void OnUnregisterReceived(ISIPExtension extension)
        {
            Console.WriteLine("Unregister received from: " + extension.ExtensionID.ToString() + "\n");
            base.OnUnregisterReceived(extension);
        }

        protected override void OnCallRequestReceived(ISessionCall call)
        {
            Console.WriteLine("Call request received. Caller: " + call.DialInfo.CallerID.ToString() + " callee: " + call.DialInfo.Dialed.ToString() + "\n");
            base.OnCallRequestReceived(call);
        }

    }
}
