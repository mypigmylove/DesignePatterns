using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01单例模式.Models;

namespace _01单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            LoaderBalence lb1=LoaderBalence.GetInstance();
            LoaderBalence lb2=LoaderBalence.GetInstance();
            LoaderBalence lb3 = LoaderBalence.GetInstance();

            if (lb1.Equals(lb2))
            {
                Console.WriteLine("相同的实例");
            }

            Console.ReadKey();
        }
    }
}
