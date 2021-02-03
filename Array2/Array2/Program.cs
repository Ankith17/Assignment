using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int ni = Convert.ToByte(Console.ReadLine());
            int[] sumarr = new int[ni];
            int sum = 0, avg = 0, max = 0;
            Console.WriteLine("Enter the Element:");
            for (int k = 0; k < ni; k++)
            {
                sumarr[k] = Convert.ToInt32(Console.ReadLine());
            }
            for (int k = 0; k < sumarr.Length; k++)
            {
                sum += sumarr[k];
            }
            avg = sum / (sumarr.Length);
            max = sumarr[0];
            for (int k = 1; k < sumarr.Length; k++)
            {
                if (max < sumarr[k])
                {
                    max = sumarr[k];
                }

            }
            Console.WriteLine("Sum is: " + sum + " and Avg: " + avg + "\n maximum of element: " + max);

            int i, j, n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];

            n = 3;
            Console.Write("Enter elements in the first matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Enter elements in the second matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nAdding two matrices: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
            int rsum1 = 0,csum1=0, rsum2 = 0, csum2 = 0;
            int[,] cs = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            for (int k = 0; k < 2; k++)
            {
                rsum1 = rsum1 + cs[k, 1];
                rsum2 = rsum2 + cs[k, 2];
                csum1 = csum1 + cs[1, k];
                csum2 += cs[2, k];
            }
            Console.WriteLine("Row 1 sum: " + rsum1);
            Console.WriteLine("Row 2 sum: " + rsum2);
            Console.WriteLine("Col 1 sum: " + csum1);
            Console.WriteLine("Col 2 sum: " + csum2);
        }


    }
}
