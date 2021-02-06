using System;

namespace Task1_2
{
    public class Matrix
    {
        public int[,] Arr { get; set; }
        private int Length { get; set; }

        public Matrix(int n)
        {
            Length = n;
            Arr = new int[n, n];
            FillArr();
        }

        private void FillArr()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Enter row");
                string[] row = Console.ReadLine()?.Split();
                if (row != null)
                    for (int j = 0; j < row.Length; j++)
                    {
                        Arr[i, j] = Convert.ToInt32(row[j]);
                    }
            }

            Console.WriteLine("Matrix  initialization completed!");
        }

        public string GetResult()
        {
            string result = "";


            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (IsSaddlePoint(i, j))
                    {
                        result += "i:" + i + " j:" + j + ";   ";
                    }
                }
            }

            return result;
        }

        private bool IsSaddlePoint(int i, int j)
        {
            return ((FindMinElementInRow(i) == j && FindMaxElementInCol(j) == i) ||
                    (FindMaxElementInRow(i) == j && FindMinElementInCol(j) == i));
        }

        public int FindMaxElementInRow(int i)
        {
            int max = Int32.MinValue;
            int maxId = -1;
            for (int k = 0; k < Length; k++)
            {
                if (Arr[i, k] > max)
                {
                    max = Arr[i, k];
                    maxId = k;
                }
            }

            return maxId;
        }

        public int FindMinElementInRow(int i)
        {
            int min = Int32.MaxValue;
            int minId = -1;
            for (int k = 0; k < Length; k++)
            {
                if (Arr[i, k] < min)
                {
                    min = Arr[i, k];
                    minId = k;
                }
            }

            return minId;
        }

        public int FindMaxElementInCol(int j)
        {
            int max = Int32.MinValue;
            int maxId = -1;
            for (int k = 0; k < Length; k++)
            {
                if (Arr[k, j] > max)
                {
                    max = Arr[k, j];
                    maxId = k;
                }
            }

            return maxId;
        }

        public int FindMinElementInCol(int j)
        {
            int min = Int32.MaxValue;
            int minId = -1;
            for (int k = 0; k < Length; k++)
            {
                if (Arr[k, j] < min)
                {
                    min = Arr[k, j];
                    minId = k;
                }
            }

            return minId;
        }
    }
}