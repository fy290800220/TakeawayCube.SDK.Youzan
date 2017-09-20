using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace YouZanSdkNetCore.Util
{
    public class MD5Util
    {
        private MD5Util()
        {
        }

        public static string Hash(string input)
        {
            var cl = input;
            var md5 = MD5.Create();
            var s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            return s.Aggregate("", (current, t) => current + t.ToString("X2"));
        }
    }
}
