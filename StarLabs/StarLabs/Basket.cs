using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public class Basket : IEnumerable
    {
        public List<Shirt> Shirt = new List<Shirt>();
        public List<Pants> Pants = new List<Pants>();
        
        protected int totalBasket;
        public int TotalBasket { get; set; }
        
        public int GetTotalPrice()
        { 
            foreach (Shirt item in Shirt)
            {
                Console.WriteLine($@"Shirt: {item.Name} - R{item.GetPriceShirt()}");
                TotalBasket = TotalBasket + item.GetPriceShirt();
            }
            foreach (Pants item in Pants)
            {
                Console.WriteLine($@"{item.GetType()}: {item.Name} - R{item.GetPricePants()}");
                TotalBasket = TotalBasket + item.GetPricePants();
            }
            Console.WriteLine("================================");
            return TotalBasket;
        }

        //Just created to prevent IEnumerable from throwing an error.
        public IEnumerator GetEnumerator()
        {
            foreach (Shirt item in Shirt)
            {
                totalBasket = totalBasket + item.GetPriceShirt();
                yield return item.GetPriceShirt();
            }
        }
        public Basket()
        {
            
        }
       

        
    }
}
