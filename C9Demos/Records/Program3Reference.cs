using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            var dotNedder = new DotNedder("Tom", "Tester");
            Console.WriteLine($"This DotNedder is called {dotNedder.FirstName} {dotNedder.LastName}");

            var newOne = dotNedder with { FirstName = "Maria" };
                       
            Console.WriteLine($"Reference ident? {Object.ReferenceEquals(dotNedder, newOne)}");
            Console.WriteLine($"Daten ident? {Object.Equals(dotNedder, newOne)}");

            // Noch ein Tom - huch...
            var nochEiner = newOne with { FirstName = "Tom" };
            Console.WriteLine($"Reference ident? {Object.ReferenceEquals(dotNedder, nochEiner)}");
            Console.WriteLine($"Daten ident? {Object.Equals(dotNedder, nochEiner)}");

            // Das ist immer noch verboten!
            // newOne.FirstName = "Hans";
        }
    }

    record DotNedder(string FirstName, string LastName);
}
