//using System;

//namespace InitOnly
//{

//    // Lösung 2 C#9 - Init
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            DotNedder ich = new DotNedder
//            {
//                FirstName = "Stephan",
//                LastName = "Huewe",
//            };

//            Console.WriteLine($"Hallo, mein Name ist {ich.FirstName} {ich.LastName}");
//            ich.FirstName = "Hans"; // Oh no :-(
//            Console.WriteLine($"Hallo, mein Name ist {ich.FirstName} {ich.LastName}");

//            // Readonly...Static.
//        }
//    }

//    public class DotNedder
//    {
//        public string FirstName { get; init; }
//        public string LastName { get; init; }

//    }
//}
