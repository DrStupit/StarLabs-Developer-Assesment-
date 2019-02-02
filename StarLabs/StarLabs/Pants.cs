using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public abstract class Pants : Product
    {
        public Pants()
        {

        }
        public Pants(string name, string size)
            : base(name, size)
        {

        }

        public virtual int GetPricePants()
        {
            int pantsPrice;
            pantsPrice = GetPrice();
            return pantsPrice;
        }

        public override void Display()
        {
            base.Display();
        }

    }
}
