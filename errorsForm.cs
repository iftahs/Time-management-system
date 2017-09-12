using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bs_Pro14
{
    public partial class errorsForm : Form
    {
        public errorsForm()
        {
            InitializeComponent();
        }

        public errorsForm(string message)
        {
            InitializeComponent();
            txtError.Text = message;
            if (message[0] >= 'א' && message[0] <= 'ת')
                txtError.RightToLeft = RightToLeft.Yes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
