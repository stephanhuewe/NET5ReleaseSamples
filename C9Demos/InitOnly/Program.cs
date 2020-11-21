using System;

namespace InitOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            DotNedder ich = new DotNedder
            {
                FirstName = "Stephan",
                LastName = "Huewe",
            };

            Console.WriteLine($"Hallo, mein Name ist {ich.FirstName} {ich.LastName}");
            ich.FirstName = "Hans"; // Oh no :-(
            Console.WriteLine($"Hallo, mein Name ist {ich.FirstName} {ich.LastName}");

        }
    }

    public class DotNedder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}
