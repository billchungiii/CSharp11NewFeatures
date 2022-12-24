namespace PatternMatchingSapnSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
           {
                  "45600001",
                  "45600002",
                  "45700003",
                  "45600004",
                  "45700005",
           };

            foreach (var item in list)
            {
                Console.WriteLine($"by span {item} is  {Is456BySpan(item)}");
                Console.WriteLine($"by string {item} is  {Is456ByString(item)}");
            };
        }

        static bool Is456BySpan(ReadOnlySpan<char> source)
        {
            return source.Slice(0, 3) is "456";
        }

        static bool Is456ByString(string source)
        {
            return source.Substring(0, 3) is "456";
        }
    }
}