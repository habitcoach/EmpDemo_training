using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{

    

    public class Employee : IComparable<Employee>
    {
       

        
      
        public string? Name { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
