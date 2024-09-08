using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___Classes_and_files
{
    // Toy class definition
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Aisle
        {
            get
            {
                return Manufacturer.Substring(0, 1).ToUpper() + Price.ToString().Replace(".", "");
            }
        }

        public Toy(string manufacturer, string name, double price, string image)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = price;
            Image = image;
        }

        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }
    }
}
