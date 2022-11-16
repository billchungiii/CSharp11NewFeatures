namespace ListPatternsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 9, 8, 7, 6, 5, 3 };
            var result = array switch
            {
                [1, .. var s, 3] => string.Join("-", s),
                [1, 2] => "A",
                [2, 5] => "B",
                [1, _] => "C",
                [..] => "D"
            };
            Console.WriteLine(result);
        }
    }
}