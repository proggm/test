using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый диапозон числа: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("введите второй диапозон числа: ");
            int second = int.Parse(Console.ReadLine());         
            int[] array = new int[10];            
            foreach( var item in List(array,first,second))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static int[] List(int[] array, int first, int second)
        {
            Random random = new Random();

            for(int i = 0; i < array.Length; i++)   
            {
                array[i] = random.Next(first,second);
            }
            return array;
        }
    }
}
