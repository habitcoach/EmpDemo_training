
using Newtonsoft.Json;
using System.Collections;
using System.IO;
using System.Net.WebSockets;
using System.Xml.Serialization;

namespace EmpDemo
{
    public class Program
    {
        static string diaryFilePath = @"D:\Test\JsonValue.txt";
        static void Main(string[] args)
        {



            StudentContext context = new StudentContext();

          

            Student student = new Student() { Name = "Name03", Age = 40, Title = "Title03" };
            Student student2 = new Student() { Name = "Name04", Age = 40, Title = "Title04" };

            context.Add(student2);
            context.Add(student);

            context.SaveChanges();

            var stuInfo = context.DemoStudent.ToList();

            foreach (var stu in stuInfo)
            {
                Console.WriteLine(stu.Name);
                Console.WriteLine(stu.Age);
            }

        }


    }

   


}
