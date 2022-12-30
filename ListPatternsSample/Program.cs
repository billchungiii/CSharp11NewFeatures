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

            List<int> list = new List<int>();
            recursive(array, list);
            Console.Write(string.Join(",", list));

            void recursive(int[] source, List<int> r)
            {
                switch (source)
                {
                    case [var x, var y, .. var z]:
                        AddResult(z, r, x, y);
                        break;
                    case [var x, .. var z]:
                        AddResult(z, r, x);
                        break;
                    case []: return;
                };
            }

            void AddResult(int[] source, List<int> r, int a, int b = 0)
            {
                r.Add(a + b);
                recursive(source, r);
            }
        }
    }
}