using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.App
{
    internal class DALFactory
    {


        public IDAL GetDAL()
        {

            return new DAL();
        }
    }
}
