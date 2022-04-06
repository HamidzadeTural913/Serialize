using System;
using System.IO;

namespace Serialize_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileadress = Path.Combine(@"C:\Users\User\Dropbox\PC\Desktop\HT", "Hello.txt");
            //Console.WriteLine(fileadress);
            string adress = @"C:\Users\User\Dropbox\PC\Desktop\HT";
            string adress1 = @"C:\Users\User\Dropbox\PC\Desktop\HT\Another";

            string anotherfileadress = Path.Combine(@"C:\Users\User\Dropbox\PC\Desktop\HT", "Good.txt");
            string anotherfileadress1 = Path.Combine(@"C:\Users\User\Dropbox\PC\Desktop\HT", "Good.txt", "Data.txt");
            string anotherfileadress2 = Path.Combine(@"C:\Users\User\Dropbox\PC\Desktop\HT", "Good.txt", "Database.txt");
            string anotherfileadress3 = Path.Combine(@"C:\Users\User\Dropbox\PC\Desktop\HT", "Good.txt", "Wexsi.txt");

            //StreamWriter streamwriter = new StreamWriter(anotherfileadress1, true);
            //for (int i = 0; i < 3; i++)
            //{
            //    streamwriter.WriteLine("product" + i);
            //}
            //streamwriter.Close();

            //streamwriter.Flush();

            StreamReader streamReader = new StreamReader(anotherfileadress2);
            string data = streamReader.ReadToEnd();
            Console.WriteLine(data);
            streamReader.Close();

            //Directory.CreateDirectory(anotherfileadress);
            //File.Create(adress1);
            //File.Create(anotherfileadress1);
            //File.Create(fileadress);

            //File.Create(anotherfileadress2);
            //File.Create(anotherfileadress3);

            //Directory.Delete(adress, true);

            //if (File.Exists(fileadress))
            //{
            //    File.Delete(fileadress);
            //}
            //else
            //{
            //    Console.WriteLine("Fayl yoxdur");
            //}

            //foreach (var item in Directory.GetFiles(anotherfileadress))
            //{
            //    Console.WriteLine(item);
            //}






        }
    }
}
