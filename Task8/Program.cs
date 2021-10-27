using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\o.cheremikin\Desktop\РАБОТА\ПО\ОБУЧЕНИЕ\ЗАНЯТИЯ\Занятие 8\Files");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                foreach (var it in item.GetDirectories())
                    Console.WriteLine(it.Name);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
