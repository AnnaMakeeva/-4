using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace уРОК4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводим переменную N (максимальное число) и Result(для накапливания суммы)
            int N = Convert.ToInt32(Console.ReadLine());
            int Result = 0;

            // 1 <= i <= N
            for (int i = 1; i <= N; i++) 
            {
                Result = Result + 2 * i - 1;

                Console.WriteLine("Квадрат числа {0} равен {1}", i, Result);
                
            }
            
            Console.ReadKey();
        }

        
    }
}
