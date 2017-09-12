using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Bs_Pro14.Utilities;

namespace Bs_Pro14.Class
{
    public class StudentS: PersonS
    {
        public StudentS(DataRow dr) : base(dr)
        {

        }
        //C'ctor
        public StudentS(StudentS other) : base(other)
        {

        }
    }
}
