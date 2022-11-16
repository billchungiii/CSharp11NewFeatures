namespace StaticVirtualInInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle r1 = new MyRectangle { Height = 5, Width = 5 };
            MyRectangle r2 = new MyRectangle { Height = 10, Width = 10 };
            var area = r1 + r2;
            Console.WriteLine(area);
            checked
            {
                var checkedArea = r1 + r2;
            }
            var x = MyRectangle.Add(9, 9);
        }
    }

    public interface IMyAreaAddOperator<T> where T : IMyAreaAddOperator<T>
    {
        static abstract int operator +(T source, T other);

        static abstract int Add(int x, int y);
    }
    public class MyRectangle : IMyAreaAddOperator<MyRectangle>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area { get => Width * Height; }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int operator +(MyRectangle source, MyRectangle other)
        {
            return source.Area + other.Area;
        }

        public static int operator checked +(MyRectangle left, MyRectangle right)
        {
            return left.Area + right.Area;
        }
    }
}