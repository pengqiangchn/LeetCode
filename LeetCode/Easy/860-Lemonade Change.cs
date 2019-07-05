using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution860
    {
        public bool LemonadeChange(int[] bills)
        {
            int int5 = 0;
            int int10 = 0;

            for (int i = 0; i < bills.Length; i++)
            {
                //每次从大钱进行找钱，如果没找到，则说明余额无法找零
                int money = bills[i] - 5;

                //找零10
                if (money > 10 && int10 > 0)
                {
                    money -= 10;
                    int10--;
                }

                //找零5
                if (money > 0 && int5 > 0)
                {
                    while (int5 > 0 && money > 0)
                    {
                        money -= 5;
                        int5--;
                    }
                }

                //还剩余钱没有找完，说明失败
                if (money > 0)
                {
                    return false;
                }
                else
                {
                    //如果成功，则将刚刚的钱收起来 并重新排序
                    if (bills[i] == 5)
                    {
                        int5++;
                    }
                    else if (bills[i] == 10)
                    {
                        int10++;
                    }
                }
            }

            return true;
        }

        //用List 去循环，还是太慢了
        //public bool LemonadeChange(int[] bills)
        //{
        //    List<int> balance = new List<int>();

        //    for (int i = 0; i < bills.Length; i++)
        //    {
        //        //每次从大钱进行找钱，如果没找到，则说明余额无法找零
        //        int money = bills[i] - 5;
        //        for (int j = balance.Count - 1; j >= 0 && money > 0; j--)
        //        {
        //            if (balance[j] <= money)
        //            {
        //                money -= balance[j];
        //                balance.RemoveAt(j);
        //            }
        //        }

        //        //还剩余钱没有找完，说明失败
        //        if (money > 0)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            //如果成功，则将刚刚的钱收起来 并重新排序
        //            balance.Add(bills[i]);
        //            balance.Sort();
        //        }
        //    }

        //    return true;
        //}
    }
}
