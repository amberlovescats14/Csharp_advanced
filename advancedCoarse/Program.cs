using System;
namespace advancedCoarse
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dictionary = new generics.GenericDictionary<string, Book>();
            //dictionary.Add("Fiction", new Book("Twilight", "Stephanie Meyers"));

            var utilities = new generics.Utilities();
            var result = utilities.Pendulum(new[] { 6, 6, 8, 5, 10 });
            Console.WriteLine(string.Join(",", result));
        }


    }
}
