using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardCalculator
{
    class Calculate
    {
        private int i1;
        private int i2;

        public Calculate() { }

        public int Input1
        {
            get
            {
                return i1;
            }

            set
            {
                i1 = value;
            }
        }
        public int Input2
        {
            get
            {
                return i2;
            }

            set
            {
                i2 = value;
            }
        }

        public int Addition()
        {
            int total;
            total = i1 + i2;

            return total;
        }
    }
}
