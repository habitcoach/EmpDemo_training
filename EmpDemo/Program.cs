
namespace EmpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee AliEmp = new Employee();

            AliEmp.Id = 1;
            AliEmp.Name = "Ali something";
            AliEmp.Address = "Oman";
            AliEmp.Title = "Manager";
            AliEmp.Phone = 99999999;

            Console.WriteLine("The emp detials are: ");

            Console.WriteLine(AliEmp.Name + "\n" + AliEmp.Id +"\n"+ AliEmp.Phone);


        }

        
    }
    // <class name> <obj name> = new <class name>();
    
}
