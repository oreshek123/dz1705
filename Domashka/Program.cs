using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Random random = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1,10));
            }

            list = list.OrderBy(o => o).ToList();
            Console.WriteLine(list[list.Count - 1]);
            int sum = 0;
            for (int i = 0; i < list.Count; i = i + 2)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            //2
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
            PrintList(list);
            //3
            List<double> listDouble = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                listDouble.Add(random.Next(1, 10) + Math.Round(random.NextDouble(), 2));
            }
            double avg = 0;
            avg = listDouble.Sum(o => o) / listDouble.Count;
            Console.WriteLine(avg);
            foreach (int item in list.Where(o => o > avg))
            {
                Console.WriteLine($"{item} > {avg}");
            }
            //4
            string strok = "nastya";
            List<char> chariki = strok.ToList();
            chariki.Reverse();
            foreach (char c in chariki)
            {
                Console.WriteLine(c);
            }
            //5
            string str = "nastya";
            string str2 = "aytsan";

            string s3 = "";
            foreach (char item in str.Reverse())
            {
                s3 += item;
            }

            if (s3 == str2)
            {
                Console.WriteLine("ok");
            }
            //6
            string text = "Be or not to be is a question";
            List<string> slova = new List<string>();
            slova = text.Split(' ').ToList();
            string bukva = "aeioyo";

            Console.WriteLine("Гласные");
            foreach (string item in slova)
            {
                if (bukva.Contains(item[0]))
                    Console.WriteLine(item);
            }

            Console.WriteLine("Согласные");
            foreach (string item in slova)
            {
                if (!bukva.Contains(item[0]))
                    Console.WriteLine(item);
            }







            Console.ReadLine();

        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine("\n");
        }
    }
}
