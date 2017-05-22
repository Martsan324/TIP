using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ozeki.Network;
namespace Serwer2._0
{
    static class Program
    {
         [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            var myPBX = new Serwer2._0.MyPBX(NetworkAddressHelper.GetLocalIP().ToString(), 20000, 20500);
            myPBX.Start();
            myPBX.gui_start();
            



            // var myPBX = new Serwer2._0.MyPBX(NetworkAddressHelper.GetLocalIP().ToString(), 20000, 20500);
            // myPBX.Start();
            //Parallel.Invoke(
            //    () => { Application.Run(new Main()); },
            //    () => { var myPBX = new Serwer2._0.MyPBX(NetworkAddressHelper.GetLocalIP().ToString(), 20000, 20500); myPBX.Start(); }
            //    );



            //myPBX.Stop();
        }
    }
}
