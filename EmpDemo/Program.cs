
using System.Collections;
using System.Net.WebSockets;

namespace EmpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp01 = new Employee() { Name = "John" };
            Employee emp02 = new Employee() { Name = "Chandler" };
            Employee emp03 = new Employee() { Name = "Ross" };
            Employee emp04 = new Employee() { Name = "Monica" };
            Employee emp05 = new Employee() { Name = "Rachel" };
            Employee emp06 = new Employee() { Name = "Gunter" };

            List<Employee> Emplist = new List<Employee>() { emp01, emp02, emp03, emp04, emp05, emp06 };
            Emplist.Sort();
            foreach (Employee emp in Emplist) { 
            
                Console.WriteLine(emp.Name);

            }
        }
        
    }
  
    
}
