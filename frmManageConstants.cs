using Bs_Pro14.Classes;
using Bs_Pro14.Utilities;
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
   
    public partial class frmManageConstants : Form
    {
        private string sqlQuery;
        private Constraints[] con;
        public frmManageConstants()
        {
            InitializeComponent();
        }
        private void fillDGV()
        {
            sqlQuery= "SELECT * FROM dbo.Constraints WHERE removed = 'True' AND approved = 'False'";
            DataTable  dt = DatabaseManager.Connect(sqlQuery);
            int count = dt.Rows.Count;
            con = new Constraints[count];
            for (int i = 0; i < count; i++)
            {
                DataRow dr = dt.Rows[i];
                con[i] = new Constraints(dr);
                try
                {
                    DataGridViewImageColumn c = new DataGridViewImageColumn();
                    dgvManageC.Rows.Add();
                    dgvManageC.Rows[i].Cells[2].Value = con[i].LecturerId;
                    dgvManageC.Rows[i].Cells[3].Value = con[i].Day;
                    dgvManageC.Rows[i].Cells[4].Value = con[i].StartTime.ToString();
                    dgvManageC.Rows[i].Cells[5].Value = con[i].EndTime.ToString();
                    dgvManageC.Rows[i].Cells[0].Value = "אשר אילוץ";
                    dgvManageC.Rows[i].Cells[1].Value = "דחה אילוץ";
                   
                }
                catch { }
            }
        }

        private void frmManageConstants_Load(object sender, EventArgs e)
        {
            dgvManageC.Width = this.Width;
            fillDGV();
        }

        private void dgvManageC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult d = MessageBox.Show("האם ברצונך לאשר?", "אשר אילוץ", MessageBoxButtons.OKCancel);
                if (d == DialogResult.Cancel)
                    return;
                else if (d == DialogResult.OK)
                {
                    Constraints.RemoveFromDataBase(con[e.RowIndex].ConstraintId);
                    MessageBox.Show("האילוץ הוסר בהצלחה!");


                }
            }
            else
            {
                DialogResult d = MessageBox.Show("האם ברצונך לדחות את האילוץ?", "דחה אילוץ", MessageBoxButtons.OKCancel);
                if (d == DialogResult.Cancel)
                    return;
                else if (d == DialogResult.OK)
                {
                    con[e.RowIndex].Removed = false;
                    Constraints.UpdateInDataBase(con[e.RowIndex]);
                    MessageBox.Show("האילוץ נדחה בהצלחה!");
                }
            }
            dgvManageC.Rows.Clear();
            fillDGV();



        }
    }
}
