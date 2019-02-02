using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public class Golfer : Shirt
    {
        public Golfer()
        {

        }
        public Golfer(string name, string size)
            : base(name, size)
        {

        }

        public override int GetPriceShirt()
        {
            int golferprice = (base.GetPriceShirt() * 2);
            base.Price = golferprice;
            return golferprice;

        }
        public override void Display()
        {
            Console.WriteLine($@"{base.Name} golfer in size {base.Size} costs: R" + this.GetPriceShirt());
        }

    }
}