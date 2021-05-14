using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экз
{
    class resh
    {

        public void zad(int n)
        {
            int kol = 0;
            int[] myArr = new int[n];
            Random r = new Random();
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = r.Next(-100, 100);
                Console.WriteLine("x{0} = {1}", i, myArr[i]);
            }
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] > 0)
                {
                    kol = kol + 1;
                }
            }
            Console.WriteLine("Количество положительных элементов = {0}", kol);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество элементов массива A:");
            int n = Convert.ToInt32(Console.ReadLine());
            resh x = new resh();
            x.zad(n);
            Console.ReadKey();
        }

    }
}


