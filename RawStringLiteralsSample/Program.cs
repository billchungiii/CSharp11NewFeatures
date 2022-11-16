namespace RawStringLiteralsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "以前你要這麼寫 \"雙引號\".";
            var s1 = """現在你可以這麼寫 "雙引號".""";
            Console.WriteLine(s);
            Console.WriteLine(s1);

            string longMessage = """
    字串可以自由自在地換行
    不用擔心換行符號的問題
    也可以加入 "雙引號"
    """;

           Console.Write(longMessage);
        }
    }
}