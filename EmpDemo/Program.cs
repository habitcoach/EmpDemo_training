
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

            

            //Student stu01 = new Student() { 
            
            //    Name="TestName",
            //    Age=25

            //};

            var empId =  Convert.ToInt32( Console.ReadLine());

            var empName = Console.ReadLine();

            Login emp1login = new Login() { EmpId = empId, EmpName = empName };

            #region Convert object to json



            //string json = JsonConvert.SerializeObject(emp1login);

            //Console.WriteLine(json);

            //File.Create(diaryFilePath).Close();

            //File.AppendAllText(diaryFilePath, json);

            #endregion

            #region Covert json back object

            // string jsonFromFile = File.ReadAllText(diaryFilePath);


            // Login? readLoginData = JsonConvert.DeserializeObject<Login>(jsonFromFile);

            //Console.WriteLine($"Login data: {readLoginData.EmpName} {readLoginData.EmpId}");   

            #endregion


            #region Convert object to XML

            XmlSerializer serializer = new XmlSerializer(typeof(Login));

            using (StreamWriter writer = new StreamWriter(@"D:\Test\studentXML.txt"))
            {


                serializer.Serialize(writer, emp1login);



            }

            #endregion

            #region Convert XML to Object

            using (StreamReader reader = new StreamReader(@"D:\Test\studentXML.txt"))
            {
                Login deserializedLogin = (Login)serializer.Deserialize(reader);

                // Display deserialized object's properties
                Console.WriteLine("\nDeserialized Student:");
                Console.WriteLine($"Name: {deserializedLogin.EmpName}");
                Console.WriteLine($"Age: {deserializedLogin.EmpId}");
               
            }

            #endregion

        }

    }

   


}
