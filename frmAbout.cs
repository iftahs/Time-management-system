using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bs_Pro14
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/about.html", curDir));
        }
    }
}
