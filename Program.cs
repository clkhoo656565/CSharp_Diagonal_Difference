using System;
using System.Collections.Generic;

namespace CSharp_Diagonal_difference
{
   class program
   {
       public static void Main(string[] args)
       {
           List<List<int>> arr = new List<List<int>>
           {
               new List<int>(){11,2,4},
               new List<int>(){4,5,6},
               new List<int>(){10,8,-12}
           };

            //Foreach loop to see the matrix
            // foreach(var item in arr)
            // {
            //     foreach(var item2 in item)
            //     {
            //         Console.WriteLine(item2);
            //     }
            // }


            int rowCount = arr[0].Count - 1;
            int right = 0;
            int left = 0;
            int result = 0;

            for(int i = 0; i < arr[0].Count; i++)
            {
                Console.WriteLine("index {0}", i);
                Console.WriteLine("item {0}",arr[i][i]);
                Console.WriteLine("item_b {0}",arr[rowCount - i][i]);

                right += arr[i][i];
                left += arr[rowCount - i][i];

                result = Math.Abs(right - left);
                Console.WriteLine("result {0}", result);
            }
            

           
       }
   }
}