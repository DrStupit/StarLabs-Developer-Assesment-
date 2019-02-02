using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public class Tshirt : Shirt
    {
        private static int idCounter;
        private readonly int id;

        private static int totalTshirts;
        private readonly int totalCostTshirts;

        

        public int Id { get; set; }
        public static int IdCounter { get; set; }

        public Tshirt(string name, string size)
            : base(name, size)
        {
            Tshirt.IdCounter++;
        }
        public Tshirt()
        {
            Tshirt.IdCounter++; 
        }

        public override int GetPriceShirt()
        {
            int tshirtPrice = base.GetPriceShirt();
            return tshirtPrice;
        }

        public override void Display()
        {
            Console.WriteLine("Current TShirts is: " + Tshirt.IdCounter);
            Console.WriteLine($@"{base.Name} tshirt in size {base.Size} costs: R"+this.GetPriceShirt());
        }

         


}
}
