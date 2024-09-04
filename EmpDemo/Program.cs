
using System.Collections;
using System.Net.WebSockets;

namespace EmpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
           Demo<int,string> commonObj = new Demo<int,string>();

           Demo<double,bool> commonObj02 = new Demo<double,bool>();



            commonObj.Prop01 = 123;
            commonObj.Prop02 = " some value";
            commonObj.PrintValue();
            Console.WriteLine(commonObj.PrintValue02(2));
            Console.WriteLine(commonObj.PrintValue02("string"));

           
        }
        
    }
  
    
}
