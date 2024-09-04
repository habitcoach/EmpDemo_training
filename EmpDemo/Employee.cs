using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{

    class Vehicle {

        public string Brand { get; set; }
        public string Model { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped!");
        }

        public virtual void Drive()
        {
            Console.WriteLine("vehicle is driving.");
        }

    }


    sealed class Car : Vehicle {

       
        public int NumberOfDoors { get; set; }

        public override void Drive()
        {
            Console.WriteLine("Car is driving.");
        }


    }

    class SuperCar : Vehicle
    {


        public int HP { get; set; }

        public void Race()
        {
            Console.WriteLine("driving.");
        }


    }


}
