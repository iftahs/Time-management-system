using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bs_Pro14.Utilities;
using Bs_Pro14.Class;
using Bs_Pro14.Classes;

namespace Bs_Pro14
{
    public partial class Schedule : Form
    {
        PersonS user;
        ScheduleC Sc = new ScheduleC();
        public Schedule(PersonS user)
        {
            this.user = new PersonS(user);
            InitializeComponent();
            Sc.realtimeUpdateSch(Schdule, user);
            textBox1.AppendText(Sc.checkNumCredit(user).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("נשלח להדפסה");
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
