using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Product
    {
        private string name;
        private double value;

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
        public double Value
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
    }
}
