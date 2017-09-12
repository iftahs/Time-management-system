using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bs_Pro14.Class
{
    public class MaintenanceS: PersonS
    {
        public MaintenanceS(DataRow dr) :base(dr)
        {

        }
        //C'ctor
        public MaintenanceS(MaintenanceS other) : base(other)
        {

        }
    }
}
