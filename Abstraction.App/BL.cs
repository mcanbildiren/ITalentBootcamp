using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.App
{

 


    internal class BL
    {
        private IDAL _dal;

        public BL(IDAL dal)
        {

            _dal = dal;
            
        }


        public void SetDAL(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProduct()

        {
            var product = (_dal.GetProduct().Select(x => new Product()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price * 1.18M,
                Created = x.Created
            })).ToList();



            return product;

        }





    }
}
