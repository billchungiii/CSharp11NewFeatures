using System.Text;

namespace UTF8StringSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "魯夫";
            var b1 = Encoding.Unicode.GetBytes(s1);
            ReadOnlySpan<byte> b2 = "魯夫"u8;
            Console.WriteLine(string.Join("-", b1));
            Console.WriteLine(string.Join("-", b2.ToArray()));
            var b3 = "魯夫"u8.ToArray();
        }
    }
}