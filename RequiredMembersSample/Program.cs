using System.Diagnostics.CodeAnalysis;

namespace RequiredMembersSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("ABC", "DEF");
        }
    }

    public class Person
    {
        [SetsRequiredMembers]
        public Person(string firstName, string lastName) =>
        (FirstName, LastName) = (firstName, lastName);   
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
    }

}