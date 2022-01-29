using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаданиеWpf14
{
    public enum ProductsTypes
    {
        Food,
        Tech
    }

    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Image { get; set; }
        public ProductsTypes Category { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
