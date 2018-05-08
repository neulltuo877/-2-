using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 類別練習2主控台
{
    class Teachers
    {
        private string name;
        private string dagree;
        private string expertise;
        private int phone;
        private string email;

        public string Name
        {
            get => name == null ? "null" : name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    name = "null";
                }
                else
                {
                    name = value;
                }

            }
        }


    }
}
