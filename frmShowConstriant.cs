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
    public partial class frmShowConstriant : Form
    {

        private string id;
        private string sqlQuery;
        Constraints[] constrian;
        public frmShowConstriant()
        {
            InitializeComponent();
            sqlQuery = "SELECT * FROM dbo.Constraints";
        }
        public frmShowConstriant(string id) : this()
        {
            sqlQuery = "SELECT * FROM dbo.Constraints where lecturerId = '" + id + "'";
            this.id = id;
            dgvConstriants.Width = this.Width;
            fillList();

        }

        private void fillList()
        {
            DataTable dt = DatabaseManager.Connect(sqlQuery);
            int count = dt.Rows.Count;

            constrian = Constraints.getConstraintsByLecturer(id);
            for (int i = 0; i < count; i++)
            {
                dgvConstriants.Rows.Add();
                dgvConstriants.Rows[i].Cells[0].Value = "מחק";
                dgvConstriants.Rows[i].Cells[1].Value = constrian[i].Day;
                dgvConstriants.Rows[i].Cells[2].Value = constrian[i].Semesterid;
                dgvConstriants.Rows[i].Cells[3].Value = constrian[i].StartTime;
                dgvConstriants.Rows[i].Cells[4].Value = constrian[i].EndTime;
                if (constrian[i].Removed == false && constrian[i].Approved == false)
                {
                    dgvConstriants.Rows[i].Cells[5].Value = "זמין";
                }
                else if (constrian[i].Removed == true && constrian[i].Approved == false)
                {
                    dgvConstriants.Rows[i].Cells[5].Value = "טרם טופל";
                }
                else if (constrian[i].Approved == false)
                {
                    dgvConstriants.Rows[i].Cells[5].Value = "טרם טופל";
                }
            }
        }

        private void dgvConstriants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                constrian[e.RowIndex].Removed = true;
                Constraints.UpdateInDataBase(constrian[e.RowIndex]);
                RefreshList();
            }
        }
        public void RefreshList()
        {
            dgvConstriants.Rows.Clear();
            dgvConstriants.Refresh();
            fillList();
        }

        private void frmShowConstriant_Load(object sender, EventArgs e)
        {
            dgvConstriants.Width = this.Width;
        }
    }
}
