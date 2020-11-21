//using System;

//namespace InitOnly
//{

//    // Lösung 1, Constructor und Setter weg
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            DotNedder ich = new DotNedder("Stephan", "Huewe");

//            Console.WriteLine($"Hallo, mein Name ist {ich.FirstName} {ich.LastName}");
//            ich.FirstName = "Hans"; // Oh no :-(
//            Console.WriteLine($"Hallo, mein Name ist {ich.FirstName} {ich.LastName}");

//        }
//    }

//    public class DotNedder
//    {
//        public DotNedder(string firstname, string lastName)
//        {
//            FirstName = firstname;
//            LastName = lastName;
//        }

//        public string FirstName { get; }
//        public string LastName { get; }

//    }
//}
