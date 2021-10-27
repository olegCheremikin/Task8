using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Log.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(0, 10));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                int[] intArrFile = File.ReadAllLines(path).Select(int.Parse).ToArray();
                int sum = intArrFile.Sum();
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine("Сумма чисел: {0}",sum);
            }
            Console.ReadKey();
        }
    }
}