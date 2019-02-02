using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Basket basket = new Basket();
            //Test tshirt code
            var tshirt = new Tshirt();
            tshirt.Name = "DC Comics";
            tshirt.Size = "m";
            basket.Shirt.Add(tshirt);

            Tshirt tshirt1 = new Tshirt();
            tshirt1.Name = "Starling City";
            tshirt1.Size = "l";
            basket.Shirt.Add(tshirt1);
            //basket.AddTshirts(tshirt);
            //tshirt.Display();



            Tshirt tshirt2 = new Tshirt();
            tshirt2.Name = "The Flash";
            tshirt2.Size = "l";  
            basket.Shirt.Add(tshirt2);
            //Console.WriteLine(tshirt2.GetPrice());
            //basket.AddTshirts(tshirt2);
            //tshirt2.Display();

            Golfer golfer = new Golfer();
            golfer.Name = "The Sheldon Cooper";
            golfer.Size = "l";
            basket.Shirt.Add(golfer);
            //Console.WriteLine(golfer.GetPrice());
            //basket.AddGolfers(golfer);
            // golfer.Display();

            Jeans jeans = new Jeans();
            jeans.Name = "Batman Jeans";
            jeans.Size = "l";
            basket.Pants.Add(jeans);
            //basket.AddJeans(jeans);
           

            FormalPants fp = new FormalPants();
            fp.Name = "The Joker";
            fp.Size = "l";
            basket.Pants.Add(fp);
            //basket.AddFp(fp);


            
            Console.WriteLine("Your total price is: R" + basket.GetTotalPrice());
            Console.WriteLine("================================");
            Console.Read();
            //This now needs to go into the Basket class as a method, and allow a single basket method to be called to create a cart....
            /*List<int> teeList = new List<int>();
            teeList.Add(tshirt.GetTshirtPrice()); //position 0
            teeList.Add(tshirt2.GetTshirtPrice()); //position 1
            teeList.Add(golfer.GetGolferPrice());
            teeList.Add(jeans.GetJeansPrice());
            teeList.Add(fp.GetFormalsPrice());
            
            for (int i = 0; i < teeList.Count; i++)
            {
                totalBasket = totalBasket + teeList[i];
                Console.WriteLine($@"Line Item: Price - R"+teeList[i]);
            }*/

        }
    }
}
