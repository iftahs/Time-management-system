using Bs_Pro14.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bs_Pro14.Classes
{
    class LessonInSemester
    {
        private string name ,day;
        private Time start, end;

        public LessonInSemester()
        {
        }

        //constractuer
        public LessonInSemester(string name,string Nday,Time Nstart,Time Nend)
        {
            this.name = name;
            day = Nday;
            start = Nstart;
            end = Nend;
        }

        public string Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal Time End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }

        internal Time Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public string ToString()
        {
            return "day :"+day+"\nthe name lectuer is:"+ name + "\nstart in:" + start + "\nend in:" + end;
        }

    }
}
