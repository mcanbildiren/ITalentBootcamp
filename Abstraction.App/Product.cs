using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.App
{
    internal class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Created.ToShortDateString()}";
        }
    }
}
