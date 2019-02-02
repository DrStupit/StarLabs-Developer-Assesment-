using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public class FormalPants : Pants
    {
        public FormalPants()
        {

        }
        public FormalPants(string name, string size)
            : base(name, size)
        {

        }

        public override int GetPricePants()
        {
            int formalsPrice = (base.GetPricePants() + 30);
            base.Price = formalsPrice;
            return formalsPrice;

        }
        public override void Display()
        {
            Console.WriteLine($@"{base.Name} formal pants in size {base.Size} costs: R" + this.GetPricePants());
        }

    }
}