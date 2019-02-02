using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public class Jeans : Pants
    {
        private static int idCounter;
        private readonly int id;
       
        public int Id { get; set; }
        public static int IdCounter { get; set; }

        public Jeans(string name, string size)
            : base(name, size)
        {
            Jeans.IdCounter++;
        }
        public Jeans()
        {
            Jeans.IdCounter++;
        }

        public override int GetPricePants()
        {
            int jeansPrice = base.GetPricePants();
            return jeansPrice;
        }

        public override void Display()
        {
            Console.WriteLine("Current Jeans is: " + Jeans.IdCounter);
            Console.WriteLine($@"{base.Name} jeans in size {base.Size} costs: R" + this.GetPricePants());
        }


    }
}
