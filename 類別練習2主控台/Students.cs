using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 類別練習2主控台
{
    class Students
    {
        private string name;
        private int grade;
        private int school;
        private string clas;

        public string Name
        {
            get { return name ?? "null"; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    name = null;
                else
                    name = value;
            }
        }

        public int Grade
        {
            get { return grade < 1 ? 1 : grade; }

            set
            {
                if (value < 1)
                    grade = 1;
                else
                    grade = value;
            }
        }



        public int School
        {
            get
            {
                return school < 0 ? 0000000 : school;
            }

            set
            {
                if (value < 0 || value.ToString().Length < 7)
                    school = 0000000;
                else
                    school = value;
            }
        }
    }
}
