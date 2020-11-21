// *****SAMPLE 1 * ****
using System;

namespace TopLevelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

// ***** SAMPLE 2 *****
//// Top Level
//using System;
//Console.WriteLine("Hello World!");

//// More Top Level
//System.Console.WriteLine("Kennt man aus Python...z.B.");


// ***** SAMPLE 3 *****
//// CL-Args wie gehabt
//var p1 = args[0];
//var p2 = args[1];

//System.Console.WriteLine($"Die Parameter lauten {p1} und {p2}");


// ***** SAMPLE 4 *****
//// Lokale Funktionen
//int Addition(int x, int y)
//{
//    var result = x + y;
//    return result;
//}

//var erg = Addition(3, 5);
//System.Console.WriteLine($"Das Ergebnis ist {erg}");


// ***** SAMPLE 5 *****
//// Geschachtelte Funktionen

//Test();

//void Test()
//{
//    void MoreTest()
//    {
//        System.Console.WriteLine("Noch mehr Test");
//    }

//    System.Console.WriteLine("Erstmal testen");
//    MoreTest();

//}
