using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.App
{
    internal class OracleDAL : IDAL
    {
        public List<Product> GetProduct()
        {
            return new List<Product>()
            {

                new(){ Id=1, Name="Oracle Kalem 1", Price=100, Created=DateTime.Now},
                  new(){ Id=2, Name="Oracle Kalem 2", Price=100, Created=DateTime.Now},
                    new(){ Id=3, Name="Oracle Kalem 3", Price=100, Created=DateTime.Now}

            };
        }
    }
}
