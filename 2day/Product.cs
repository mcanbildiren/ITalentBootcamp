using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2day
{
   public  class Person
    {

        public int Name { get; set; }

        public virtual void Write()
        {
            Console.WriteLine("(Console) Person Write");
        }


    }


    public class Manager:Person
    {

        public override void Write()
        {
            Console.WriteLine("(Console) Manager Write");
        }




    }



    


  







}
