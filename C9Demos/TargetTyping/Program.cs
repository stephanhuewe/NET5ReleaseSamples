using System;
using System.Collections.Generic;

namespace TargetTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            DotNedder augsburger = new DotNedder("Walter", "Ranzmayr");

            // Weniger Tipparbeit? Geht nicht mit var
            DotNedder targetTypingAugsburger = new ("Walter", "Ranzmayr");

            // Hier ist es sinnvoller... einmal DotNedder, Rest ist klar
            var NetMeetup = new List<DotNedder>
            {
                new ("Walter", "Ranzmayer"),
                new("Foo", "Bar"),
                new("More", "Foobar"),
                new("Maria", "Mustermann")
            };
        }
    }

    public class DotNedder
    {
        private string _firstname;
        private string _lastname;

        public DotNedder(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }
    }
}
