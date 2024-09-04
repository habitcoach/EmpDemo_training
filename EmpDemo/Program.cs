
using System.Collections;
using System.Net.WebSockets;

namespace EmpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee Emp01 = new Employee(1, "Name01", "Oman",999999, "Manager");
            Employee Emp02 = new Employee(2, "Name02", "Place02",999999, "Admin");
            Employee Emp03 = new Employee(3, "Name03", "Place03",999999, "Associate");

            ArrayList employees = new ArrayList();

          //  Employee[] emparray = new Employee[100];

            employees.Add(Emp01);
            employees.Add(Emp02);
            employees.Add(Emp03);

            // Read


            var readEmp = ReadEmployee(2);


             Employee ReadEmployee(int id) {

                foreach (Employee emp in employees) { 
                
                    if (emp.Id == id)
                    {
                        return emp;
                    }
                }

                return null;

            }

            readEmp.DisplayDetials();


        }

        
    }
    // <class name> <obj name> = new <class name>();
    
}
