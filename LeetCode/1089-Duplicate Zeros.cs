using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _1089_Duplicate_Zeros
    {
        public void DuplicateZeros(int[] arr)
        {
            int i = 0, j = 0;
            while (j < arr.Length)
            {
                if (arr[i] == 0)
                {
                    j++;
                }
                j++;
                i++;
            }
            j--;
            i--;

            while (i >= 0)
            {
                if (j < arr.Length)
                    arr[j] = arr[i];

                if (arr[i] == 0)
                {
                    arr[--j] = arr[i];
                }

                j--;
                i--;

                if (i == j)
                    return;
            }

        }

        //int last = arr.Length - 1;

        //    if (arr.Length == 2 && arr[0] == 0)
        //    {
        //        arr[1] = 0;
        //        return;
        //    }

        //    for (int i = 0; i<arr.Length; i++)
        //    {
        //        if (i<last)
        //        {
        //            if (arr[i] == 0)
        //            {
        //                last--;
        //            }
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //    int index = arr.Length - 1;
        //    for (int i = last; i >= 0; i--)
        //    {
        //        if (i > index)
        //        {
        //            break;
        //        }

        //        if (arr[i] == 0)
        //        {
        //            arr[index--] = 0;
        //            arr[index--] = 0;
        //        }
        //        else
        //        {
        //            if (i != 0)
        //            {
        //                arr[index--] = arr[i];
        //            }
        //        }
        //    }
    }
}
