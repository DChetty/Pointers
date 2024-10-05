using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPointer
{
    public  class Program
    {
        static unsafe void Main(string[] args) // click on lightbulb -> allow unsafe code into this project
        {
            //variables
            int a = 20;
            int b = 50;

            //create a pointer --> point to a 
            int* pointerA = &a;
            int* pointerB = &b;

            //output
            Console.WriteLine(*pointerA);
            Console.WriteLine((int)pointerA);
            Console.WriteLine(*pointerB);
            Console.WriteLine((int)pointerB);

            Console.ReadLine();

        }
    }
}
