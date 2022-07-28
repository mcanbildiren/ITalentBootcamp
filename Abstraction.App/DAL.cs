using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.App
{
    internal class DAL : IDAL
    {
       

        public List<Product> GetProduct()

        {


            return new List<Product>()
            {

                new(){ Id=1, Name="Kalem 1", Price=100, Created=DateTime.Now},
                  new(){ Id=2, Name="Kalem 2", Price=100, Created=DateTime.Now},
                    new(){ Id=3, Name="Kalem 3", Price=100, Created=DateTime.Now}

            };

        }

       
    }
}
