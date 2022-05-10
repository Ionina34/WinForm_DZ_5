using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_2
{
   public class Tovar
    {
        string name;
        string specification;
        string description;
        double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Specification
        {
            get { return specification; }
            set { specification = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                    throw new System.Exception("Цена не может быть отрицательной");
                price = value;
            }
        }
        public Tovar()
        {
            Name = "unknown";
            Specification = "unknown";
            Description = "unknown";
            Price = price;
        }

        public Tovar(string name,string specification, string description,double price)
        {
            Name = name;
            Specification = specification;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"Товар: {Name}";
        }
    }
}
