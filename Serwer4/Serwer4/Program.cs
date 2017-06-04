using System;
using Ozeki.Network;
using Ozeki.VoIP;
using System.Data.SqlClient;
using System.Data;

namespace Serwer4
{
    class Program
    {
        static void Main(string[] args)
        {

            var myPBX = new Serwer4.MyPBX(NetworkAddressHelper.GetLocalIP().ToString(), 20000, 20500);
            myPBX.Start();
            
            Console.ReadLine();
            myPBX.Stop();

        }
    }
}
