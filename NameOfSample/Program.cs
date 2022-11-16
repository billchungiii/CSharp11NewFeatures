using System.ComponentModel;

namespace NameOfSample
{
    internal class Program
    {
        [Description(nameof(Main))]
        static void Main([Description(nameof(args))] string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}