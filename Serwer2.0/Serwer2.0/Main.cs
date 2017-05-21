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

using Ozeki.Network;
using Ozeki.VoIP;

namespace Serwer2._0
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
        

        }
        public void konsola_pisz(string tekst)
        {
            lb_konsola.AppendText(tekst);
        }
    }

}
   

