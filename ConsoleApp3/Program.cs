using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {//1.task
            //Console.WriteLine("Введите число");
            //int x = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число");
            //int y = Int32.Parse(Console.ReadLine());
            //try
            //{

            //    if(x>0 && y>0)
            //    {
            //        int c = x / y;
            //        Console.WriteLine(c);

            //    }
            //    else if (y == 0)
            //    {
            //        throw new ArgumentException("Делитель 0");
            //    }
            //}
            //catch
            //{
            //    throw new ArgumentNullException("enter int");
            //}
            try
            {
                int[] array = new int[5];
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                 Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finished");
            }

        }
    }
}
