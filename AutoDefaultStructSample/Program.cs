namespace AutoDefaultStructSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public readonly struct Measurement
    {
        public Measurement(double value) 
        { 
            Value = value; 
        }

        public Measurement(double value, string description)
        {
            Value = value;
            Description = description;
        }

        public Measurement(string description)
        {
            // 會補上
            //this.<Value>k__BackingField = 0.0;
            //this.<Description>k__BackingField = "Ordinary measurement";
            Description = description;
        }

        public double Value { get; init; }
        public string Description { get; init; } = "Ordinary measurement";

        public override string ToString() => $"{Value} ({Description})";
    }

}