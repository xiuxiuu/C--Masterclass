/* Multi-dimensional arrays - FindMax

Implement the FindMax method, which given a two-dimensional array of integers, returns the maximal value from this array.

If any of the array's dimensions is zero, it means the array is empty, and the method should return -1.
*/
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int FindMax(int[,] numbers)
        {
            int height = numbers.GetLength(0);
            int width = numbers.GetLength(1);
            if (height == 0 || width == 0)
            {
                return -1;
            }
            int max = numbers[0, 0];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (numbers[i, j] > max)
                    {
                        max = numbers[i, j];
                    }
                }
            }
            return max;
        }
    }
}
