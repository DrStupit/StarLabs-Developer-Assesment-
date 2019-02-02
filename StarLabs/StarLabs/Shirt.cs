using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public abstract class Shirt : Product
    {
        public Shirt()
        {

        }
        public Shirt(string name, string size)
            :base(name, size)
        {

        }

        public virtual int GetPriceShirt()
        {
            int shirtPrice;
            shirtPrice = GetPrice();
            return shirtPrice;
        }

        public override void Display()
        {
            base.Display();
        }
        
    }
}
