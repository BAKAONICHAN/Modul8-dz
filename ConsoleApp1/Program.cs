using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int sizeOfArray=3;
            Array array = new Array(sizeOfArray,2);
            WriteLine("Первый ряд чисел");
            array[0] = 12;
            array[1] = 2;
            array[2] = 3;
            for (int i=0;i<array._size;i++)
            {                
            WriteLine(array[i]);
            }
            ReadLine();
        }
    }
}
