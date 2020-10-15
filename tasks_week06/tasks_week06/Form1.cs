using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tasks_week06.MnbServiceReference;

namespace tasks_week06
{
    public partial class Form1 : Form
    {
        var mnbService = new MNBArfolyamServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
