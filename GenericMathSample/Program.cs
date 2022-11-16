using System.Net.Http.Headers;
using System.Numerics;

namespace GenericMathSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(intList.GenericSum());
            var doubleList = new List<double> { 0.1, 0.2, 0.3 };
            Console.WriteLine(doubleList.GenericSum());  
        }
    }

    public static class GenericMathExtensions
    {
        public static T GenericSum<T>(this IEnumerable<T> source) where T : struct, IAdditionOperators<T,T,T>
        {
            T result = default(T);
            foreach (var item in source)
            {
                result += item;
            }
            return result;
        }
    }

    public class Rectangle : IAdditionOperators<Rectangle, Rectangle, int>
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get => Width * Height; }

        public static int operator +(Rectangle left, Rectangle right)
        {
            return left.Area + right.Area;
        }
        public static int operator checked +(Rectangle left, Rectangle right)
        {
            return left.Area + right.Area;
        }
    }

}