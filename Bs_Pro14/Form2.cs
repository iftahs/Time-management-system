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
using Bs_Pro14.Persons;

namespace Bs_Pro14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtPassword.Text == "")
                MessageBox.Show("חובה למלא תעודת זהות וסיסמא", "Invalid input");
            else
            {
                if (!Validations.IDValidation(txtUserID.Text))
                    MessageBox.Show("תעודת זהות לא תקינה", "Invalid input");
                else
                {
                    string id = txtUserID.Text;
                    if (id.Length < 9)
                        while (id.Length < 9)
                            id = '0' + id;
                    string sqlQuery = "select * from dbo.person where personID = '" + id + "' and password = '" + txtPassword.Text + "'";
                    DataTable dt = new DataTable();
                    dt = DatabaseManager.Connect(sqlQuery);
                    if (dt.Rows.Count == 1)
                    {
                        Program.person = new Person(dt.Rows[0]);
                        Form1 mainForm = new Form1();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("שם משתמש או סיסמא שגויים", "Invalid login");
                    DatabaseManager.CloseConnection();
                }
            }
        }

        private void txtUserID_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "תעודת זהות")
                txtUserID.Clear();
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
                txtUserID.Text = "תעודת זהות";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "סיסמא")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "סיסמא";
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
