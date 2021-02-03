using System;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size:");
            int n = Convert.ToByte(Console.ReadLine());
            int[] dup = new int[n];
            int[] nd = new int[n];
            Console.WriteLine("Enter the Element:");
            for (int i = 0; i < n; i++)
            {
                dup[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (dup[i] == dup[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            dup[k] = dup[k + 1];
                        }
                        n--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dup[i]);
            }
        }
    }
}
