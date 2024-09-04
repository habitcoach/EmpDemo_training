using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{
    public class Employee
    {
        // Prop

        
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Phone { get; set; }
        public string? Title { get; set; }

        //ctor
       
        public Employee(int id, string name, string address, int phone, string title) { 
        
            this.Phone = phone;
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Title = title;

        
        }

        public void DisplayDetials() {

            Console.WriteLine(this.Name + "\n" + this.Id + "\n" + this.Phone);

        }




        

    }
}
