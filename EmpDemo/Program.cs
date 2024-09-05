
using System.Collections;
using System.IO;
using System.Net.WebSockets;

namespace EmpDemo
{
    public class Program
    {
        static string diaryFilePath = @"D:\Test\Diary.txt";
        static void Main(string[] args)
        {



            #region File code

            //Console.WriteLine("\nEnter your diary entry:");

            //string entry = "This is the data added from c#";

            //try
            //{

            if (!File.Exists(diaryFilePath))
            {

                File.Create(diaryFilePath).Close();


            }

            //    File.AppendAllText(diaryFilePath, entry);

            //    File.Delete(diaryFilePath);

            //    File.GetAttributes(diaryFilePath);

            //}
            //catch(FileNotFoundException ex){ 

            //    Console.WriteLine("File does not exist ");
            //  }

            #endregion

            #region FileInfo code

            FileInfo diaryObj = new FileInfo(diaryFilePath);

            Console.WriteLine(diaryObj.FullName);
            Console.WriteLine(diaryObj.CreationTime.ToString());
            Console.WriteLine(diaryObj.Extension);
            Console.WriteLine(diaryObj.Length); 
            diaryObj.Delete();


            #endregion

        }

    }

   


}
