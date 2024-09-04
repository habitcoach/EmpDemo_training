using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{

    public class Vehicle {

        protected string Brand { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Brand = "  ";
        }

    }


    public class Car :Vehicle {

       
        public int NumberOfDoors { get; set; }

        public  void Drive()
        {

            Brand = "something";
           
        }


    }

    


}
