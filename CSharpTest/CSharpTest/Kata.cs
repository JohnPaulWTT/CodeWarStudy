using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpTest
{
    public partial class Kata
    {
        #region 验证码校验
        /// <summary>
        /// 验证用户输入的验证码是否正确并检验是否过期
        /// </summary>
        /// <param name="enteredCode">用户输入的验证码</param>
        /// <param name="correctCode">正确的验证码</param>
        /// <param name="currentDate">验证时间</param>
        /// <param name="expirationDate">验证截止时间</param>
        /// <returns></returns>
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            return enteredCode == correctCode && DateTime.Parse(currentDate) <= DateTime.Parse(expirationDate);
        }
        #endregion

        #region 过滤字符串中的数字字符
        public static int FilterString1(string s)
        {
            return int.Parse(new String(s.Where(Char.IsDigit).ToArray()));
        }
        public static int FilterString2(string s)
        {
            return Int32.Parse(Regex.Replace(s, @"\D", ""));
        }
        #endregion

        #region 吸血鬼数
        public static bool isVampireNumber(long x, long y)
        {
            return (x * y).ToString().OrderBy(c => c).SequenceEqual((x.ToString() + y).OrderBy(c => c));
        }
        #endregion

        #region 数组中字符串长度的极差
        //给定两个数组字符串a1和a2，每个字符串是由字母从a到z。让X成为a1中任意一个字符串，y成为a2中任意一个字符串，求max(abs(length(x) − length(y)))
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length <= 0 || a2.Length <= 0)
                return -1;
            var first = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
            var second = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));
            return Math.Max(first, second);
        }
        #endregion

        #region 比较两数组并移除重复项
        //给定两个int型数组，从integerList中去除掉在valuesList中的值并返回剩余数组
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            return integerList.Where(x => !valuesList.Contains(x)).ToArray();
        }
        #endregion
    }
}