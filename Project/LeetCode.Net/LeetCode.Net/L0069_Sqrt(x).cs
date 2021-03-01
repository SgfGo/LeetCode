using System;

/******************************************************
* author :  sgf
* 69. Sqrt(x) 开根
* email  : yubaojun12@gmail.com
* time : 2021年03月01日23:38:19
* LeetCode:https://leetcode-cn.com/problems/sqrtx/
******************************************************/
namespace LeetCode.Net
{
    public class Sqrt_x_
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(Solution3(10));
        
        }
        /// <summary>
        /// 挨打解法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Solution1(int x)
        {
            int sqrtX = (int)Math.Floor(Math.Sqrt(x));
            return sqrtX;
        }

        /// <summary>
        /// 二分法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Solution2(int x)
        {
            // 精度
            double EPSION = 0.00001;

            double low  = 0;
            double high = x;
            double mid = (low + high) / 2;
            while ((high - low) > EPSION)
            {
                // 计算平方 若大于值 中间数给于最大值 反之给与最小值
                if (mid * mid > x)
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                }
                mid = (high + low) / 2;
            }
            int sqrtX = (int)Math.Floor(mid);

            // 判断是否为整数开根
            if (mid + EPSION > sqrtX + 1)
                return sqrtX + 1;
            else
                return sqrtX;
        }

        /// <summary>
        /// 整数二分法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Solution3(int x)
        {
            int low = 0, high = x, ans = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                // 加long 防止数字过大溢出
                if ((long)mid * mid <= x)
                {
                    ans = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }


        /// <summary>
        /// 牛顿迭代法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Solution4(int x)
        {
            if (x == 0)
                return x;
            
            int sqrtX = 0;

          

            return sqrtX;
        }
    }

     
}
