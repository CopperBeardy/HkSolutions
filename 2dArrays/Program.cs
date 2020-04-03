using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int sum = 0;
            int? maxSum = null;
            //foreach top row of hour glass
            for (var row = 0; row <= 3; row++)
            {
                //starting column for hourglass
                for (var col = 0; col <= 3; col++)
                {
                    //number of rows in hour glass 3 in total
                    for (var sumRow = row; sumRow <= row + 2; sumRow++)
                    {
                        //if the second row of the hour glass just get the middle number
                        if (sumRow == row + 1)
                        {
                            //get the value of the hourglass middle row
                            sum += arr[sumRow][col + 1];
                        }
                        else
                        {
                            //columns to sum on each row
                            for (var sumcol = col; sumcol <= col + 2; sumcol++)
                            {
                                sum += arr[sumRow][sumcol];
                            }
                        }
                    }

                    //ensure max values gets assigned the first hour glass value
                    if (col == 0 && maxSum == null)
                    {
                        maxSum = sum;
                        sum = 0;
                        continue;
                    }

                    //check to see if both sum and maxSumm are 0 or sum is 0 and max sum is a negative number
                    if (sum == 0 && maxSum == 0 || sum == 0 && maxSum < 0)
                    {
                        maxSum = sum;
                        continue;
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                    //check to see which is the greater negative number
                    if (sum < 0 && maxSum < 0 && sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}