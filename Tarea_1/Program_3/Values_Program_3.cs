using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1.Program_3
{
    class Values_Program_3
    {
        public readonly string Message = "Press enter for continue ...";
        public int[] Enrollment = { 0, 1, 2, 6, 8 };
        public long[] PhoneNumber = new long[11];
        public void Pause()
        {
            Console.WriteLine(this.Message);
            Console.ReadKey();
        }

        public void array(long n)
        {

            var digits = new List<long>();

            for (; n != 0; n /= 10)
                digits.Add(n % 10);

            var arr = digits.ToArray();
            Array.Reverse(arr);

            for (long i = 0; i < 11; i++)
            {
                PhoneNumber[i] = arr[i]; 
            }
            
        }

    }
}
