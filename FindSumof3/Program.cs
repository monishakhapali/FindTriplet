﻿using System;
using System.Collections.Generic;

namespace FindSumof3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] A = { 1, 4, 45, 6, 10, 8 };
            int sum = 22;
            int arr_size = A.Length;

            find3Numbers(A, arr_size, sum);

        }
        static bool find3Numbers(int[] A,
                             int arr_size, int sum)
        {
            // Fix the first element as A[i] 
            for (int i = 0; i < arr_size - 2; i++)
            {

                // Find pair in subarray A[i+1..n-1] 
                // with sum equal to sum - A[i] 
                HashSet<int> s = new HashSet<int>();
                int curr_sum = sum - A[i];
                for (int j = i + 1; j < arr_size; j++)
                {
                    if (s.Contains(curr_sum - A[j]))
                    {
                        Console.Write("Triplet is {0}, {1}, {2}", A[i],
                                      A[j], curr_sum - A[j]);
                        Console.ReadLine();
                        return true;
                    }
                    s.Add(A[j]);
                }
            }

            // If we reach here, then no triplet was found 
            return false;
        }
    }
}
