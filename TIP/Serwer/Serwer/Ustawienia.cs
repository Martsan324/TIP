using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serwer
{
    public partial class Ustawienia : UserControl
    {
        private static Ustawienia _instance;
        internal static object bunifuCustomTextbox1_TextChanged;

        public static Ustawienia Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ustawienia();
                return _instance;
            }
        }
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {

        }
    }
}
