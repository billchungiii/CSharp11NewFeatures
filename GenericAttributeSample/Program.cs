namespace GenericAttributeSample
{
    //[ServiceFilter(typeof(ResponseLoggerFilter))]
    //[ServiceFilter<ResponseLoggerFilter>]
    [Type<string>]
    internal class Program
    {
        static void Main(string[] args)
        {
            var attribute = typeof(Program).GetCustomAttributes(false)[0] as TypeAttribute<string>;
        }
    }
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(Type t) => ParamType = t;
        public Type ParamType { get; }
    }
    public class TypeAttribute<T> : Attribute { }
}