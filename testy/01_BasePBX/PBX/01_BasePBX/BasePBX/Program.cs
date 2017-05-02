using System;
using Ozeki.Network;

namespace BasePBX
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPBX = new BasePBX.MyPBX(NetworkAddressHelper.GetLocalIP().ToString(), 20000, 20500);
            myPBX.Start();

            Console.ReadLine();
            myPBX.Stop();
        }
    }
}
