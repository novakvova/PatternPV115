using System;
using System.IO;
using System.Text;

namespace _10.Obsaever
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //WriteToFile();
            //ReadFile();
            Subject maryna = new Subject();
            new IvanObserver(maryna);
            new PeterObserver(maryna);
            Console.WriteLine("First state: 18");
            maryna.State = 18;
            Console.WriteLine("First state: 21");
            maryna.State = 21;
        }

        private static void ReadFile()
        {
            using (var fs = new FileStream("dima.txt", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                Console.WriteLine(sr.ReadLine());
                sr.Close();
                fs.Close();
            }
        }
        //Запис даних у файл
        private static void WriteToFile()
        {
            Bitoc bitoc = new Bitoc
            {
                Id = 2321,
                Name = "Біток",
                Price = 19876.70m
            };
            using (var fs = new FileStream("dima.txt", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
                sw.WriteLine(bitoc);
                sw.Close();
                fs.Close();
            }
            //
        }
    }
}
