using System;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            Matrix matrix = new Matrix(n);

            Console.WriteLine("Saddle point indexes: " + matrix.GetResult());
        }
    }
}