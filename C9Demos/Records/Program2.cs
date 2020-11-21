//using System;

//namespace Records
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var Papa = new DotNedder("Tom", "Tester");
//            Console.WriteLine($"This DotNedder is called {Papa.FirstName} {Papa.LastName}");

//            var Mama = Papa with { FirstName = "Maria" };
//            Console.WriteLine($"This DotNedder is called {Mama.FirstName} {Mama.LastName}");

//            var Kind = Papa with { FirstName = "Luise" };
//            Console.WriteLine($"This DotNedder is called {Mama.FirstName} {Mama.LastName}");

//            // Sie heißen alle gleich :-)
//        }
//    }

//    record DotNedder(string FirstName, string LastName);
//}
