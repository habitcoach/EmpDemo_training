
using System.Collections;
using System.Net.WebSockets;

namespace EmpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Vehicle TeslaCar = new Car();

            TeslaCar.Brand = "tesla";
            TeslaCar.Model = "Model 3";
            TeslaCar.Drive();   // car is driving   //veh is drving
           

           
            
           
        }
        
    }
  
    
}
