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
    }
}