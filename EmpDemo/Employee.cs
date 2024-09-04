using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{



    public class Demo<T1,T2>
    {

        public T1 Prop01 { get; set; }
        public T2 Prop02 { get; set; }
       

        public void PrintValue() { 
        
            Console.WriteLine("The value of prop1: "+ Prop01);

        }

        public T2 PrintValue02<T2>(T2 value)
        {

            return value;

        }



    }
}
