using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 16, 8, 9, 4, 3, 2, 4, 7, 7, 12, 3, 5, 4, 3, 2 };
            Console.WriteLine("Össztömeg: " + nums.Sum() + " kg");

            int dobozCount = 0;
            int dobozTomeg = 0;
            List<int> dobozTomegek = new List<int>();
            foreach (int num in nums)
            {
                dobozTomeg += num;
                if (dobozTomeg > 15)
                {
                    dobozTomegek.Add(dobozTomeg);
                    dobozCount++;
                    dobozTomeg = 0;
                }
            }
            Console.Write("\nA dobozok tartalmának tömege (kg): ");
            foreach (int tomeg in dobozTomegek)
            {
                Console.Write(tomeg + " ");
            }
            Console.WriteLine("\nDobozok száma: " + dobozCount);
        }
    }
}
