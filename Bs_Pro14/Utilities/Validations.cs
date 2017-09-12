using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bs_Pro14.Utilities
{
    abstract class Validations
    {
        public static bool IDValidation(string id)
        {
            //Check id length
            if (id.Length < 3 || id.Length > 9)
                return false;

            //If the length of the id is less then 9, it adds '0' in the beginning to get length of 9.
            if (id.Length < 9)
                while (id.Length < 9)
                    id = '0' + id;

            //Check every char id the id, if it is not numeric, it return false.
            if (!isNumric(id))
                return false;

            return true;
        }

        public static bool isNumric(string str)
        {
            if (str.Length < 1)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                    return false;
            }

            return true;
        }
    }
}
