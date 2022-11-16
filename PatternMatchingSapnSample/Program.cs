namespace PatternMatchingSapnSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadOnlySpan<char> chars1 = new ReadOnlySpan<char>(new char[] { '1', '2', '3' });
            Console.WriteLine(Is123(chars1));
            Span<char> chars2 = new Span<char>(new char[] { 'A' });
            Console.WriteLine (IsABC (chars2));
        }

        static bool Is123(ReadOnlySpan<char> s)
        {
            return s is "123";
        }

        static bool IsABC(Span<char> s)
        {
            return s switch { "ABC" => true, _ => false };
        }
    }
}