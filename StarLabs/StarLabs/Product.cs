using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabs
{
    public class Product
    {
        protected string name;
        protected string size;
        protected int price;

        public string Name { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }

        public Product()
        {

        }
        public Product(string name, string size)
        {
            this.Name = name;
            this.Size = size;
        }

        public int GetPrice()
        {
            if(this.Size == "s")
            {
                this.Price = 10;
            }
            else if(this.Size == "m")
            {
                this.Price = 20;
            }
            else if(this.Size == "l")
            {
                this.Price = 30;
            }

            return this.Price;
        }

        public virtual void Display()
        {
            Console.WriteLine("Price: R" + this.GetPrice());
        }

    }
}
