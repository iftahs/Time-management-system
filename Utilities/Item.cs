using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bs_Pro14.Utilities
{
    public class Item
    {
        public string Name;
        private int value;
        public Item(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
