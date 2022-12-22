namespace RawStringLiteralsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value1 = "這有雙雙引號 \"\"在雙雙引號內\"\"";
            Console.WriteLine(value1);
            string value2 = @"這有雙雙引號 """"在雙雙引號內""""。";
            Console.WriteLine(value2);
            string value3 = """這有雙雙引號 ""在雙雙引號內""。""";
            Console.WriteLine(value3);

            string longString1 = "長字串" + Environment.NewLine + "換行";
            Console.WriteLine(longString1);
            string longString2 = @"
長字串
換行";
            Console.WriteLine(longString2);

            string longString3 = """
      長字串
      換行
      """;
            Console.WriteLine(longString3);

            string longString4 = $"長字串{Environment.NewLine}換行";
            Console.WriteLine(longString4);
        }
    }
}