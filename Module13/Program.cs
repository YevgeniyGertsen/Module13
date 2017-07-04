using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Double> LD = new List<double>();
            List<int> l2 = new List<int>();
            List<int> l1 = new List<int>();
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                l1.Add(rnd.Next(1, 90));
                LD.Add(rnd.Next(1, 90));
                Console.Write(l1[i] + " ");
            }
            Console.WriteLine("\n---");
            l1.Sort();
            foreach (var item in l1)
            {
                Console.Write(item + " ");
                if (l1.IndexOf(item) % 2 == 0)
                {
                    sum = sum + item;
                }
                else
                {
                    l2.Add(item);
                }
            }
            Console.WriteLine("----");
            Console.WriteLine(l1[l1.Count - 2]);
            Console.WriteLine("===");
            Console.WriteLine(sum);


            foreach (var item in l2)
            {
                l1.Remove(item);
            }
            Console.WriteLine("===");
            foreach (var item in l1)
            {
                Console.Write(item+"-");
            }
            
            double d = new double();
            Console.WriteLine("\n");
            foreach (var item in LD)
            {
                d = d + item;
                Console.Write(item+"*");
            }
            Console.WriteLine("Сумма всех чисел равна {0}",d);
            d = d / LD.Count;
            Console.WriteLine("Среднее арифметическое равно "+d);

            foreach (var item in LD.Where(v=>v>d))
            {
                Console.WriteLine(item);
            }
        }
    }
}
