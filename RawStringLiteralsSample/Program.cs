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


        }
    }
}