using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1
{
    internal class rectangle
    {
        private double length;
        private double width;

        public rectangle()
        {
            length = 1.0;
            width = 1.0;
        }

        public rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void setlength(double length)
        {
            this.length = length;
        }

        public double getlength()
        {
            return this.length;
        }

        public void setwidth(double width)
        {
            this.width = width;
        }

        public double getwidth()
        {
            return this.width;
        }

        public double findarea()
        {
            return this.length * this.width;
        }

        public double findperimeter()
        {
            return 2 * (this.length + this.width);
        }
    }
}
