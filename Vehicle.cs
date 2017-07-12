using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus13actual
{
    class Vehicle
    {
        protected string type;
        protected string size;
        protected int quantity;

        public Vehicle(string type, string size, int quantity)
        {
            this.type = type;
            this.size = size;
            this.quantity = quantity;
        }

        public string getType()
        {
            return type;
        }

        public string getSize()
        {
            return size;
        }

        public int getQuantity()
        {
            return quantity;
        }
    }
}
