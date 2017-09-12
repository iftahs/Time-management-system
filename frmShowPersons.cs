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
using Bs_Pro14.Utilities;

namespace Bs_Pro14
{
    public partial class frmShowPersons : Form
    {
        private string sqlQuery;
        public frmShowPersons()
        {
            InitializeComponent();
            sqlQuery = "SELECT * FROM dbo.Person";
        }

        public frmShowPersons(string role) : this()
        {
                sqlQuery = "SELECT * FROM dbo.Person where " + role + " = 'true'";
        }

        private void fillList()
        {
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            int count = dt.Rows.Count;

            Person[] persons = new Person[count];
            for (int i = 0; i < count; i++)
            {
                persons[i] = new Person(dt.Rows[i]);
                dgvPersons.Rows.Add();
                dgvPersons.Rows[i].Cells[0].Value = "מחק";
                dgvPersons.Rows[i].Cells[1].Value = "ערוך";
                dgvPersons.Rows[i].Cells[2].Value = persons[i].ID;
                dgvPersons.Rows[i].Cells[3].Value = persons[i].FirstName;
                dgvPersons.Rows[i].Cells[4].Value = persons[i].LastName;
                dgvPersons.Rows[i].Cells[5].Value = persons[i].PhoneNumber;
            }
        }

        private void frmShowPersons_Load(object sender, EventArgs e)
        {
            dgvPersons.Width = this.Width;
            fillList();
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string id = dgvPersons.Rows[e.RowIndex].Cells["clmID"].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    deletePerson(id);
                }
                else if (e.ColumnIndex == 1)
                {
                    frmAddPerson frm = new frmAddPerson(true, id);
                    frm.Show();
                    frm.FormClosed += new FormClosedEventHandler(MyForm_FormClosed);
                }
            }
        }

        void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshList();
        }

        private void deletePerson(string id)
        {
            DialogResult d = MessageBox.Show("האם אתה בטוח שברצונך למחוק את המשתמש", "Delete user", MessageBoxButtons.OKCancel);
            if (d == DialogResult.Cancel)
                return;
            else if (d == DialogResult.OK)
            {
                Person.RemoveFromDataBase(id);
                MessageBox.Show("המשתמש נמחק בהצלחה", "Delete user");
                foreach (DataGridViewRow row in dgvPersons.Rows)
                {
                    if (row.Cells["clmID"].Value.ToString() == id)
                    {
                        dgvPersons.Rows.Remove(row);
                    }
                }
            }
        }

        public void RefreshList()
        {
            dgvPersons.Rows.Clear();
            dgvPersons.Refresh();
            fillList();
        }
    }
}
