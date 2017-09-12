using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Classes;

namespace Bs_Pro14
{
    public partial class frmSelectSmester : Form
    {
        private int sem, year;
        public frmSelectSmester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sem = semester.SelectedIndex;
            year = year1.SelectedIndex;
            Course c = new Classes.Course(1, 4, "f", 'f');
            c.setStatic(sem, year);
            this.Close();
        }
     
    }
}
