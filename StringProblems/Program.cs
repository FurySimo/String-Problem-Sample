using System;

namespace StringProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo1 = "Hello ";
            string demo2 = "World";
            string demo3= "Hello\nWorld";
            Console.WriteLine("Length of demo1 is:" + demo1.Length);
            Console.WriteLine("Change demo1 to lower case:" +demo1.ToLower());
            Console.WriteLine("Change demo2 to upper case:" +demo2.ToUpper());
            Console.WriteLine("Merge demo1 and demo2:" + string.Concat(demo1, demo2));
            Console.WriteLine($"Merge demo1 and demo2 with interpolation: { demo1}{ demo2}");
            Console.WriteLine("5th charater of demo1 is:" + demo1[4]);
            Console.WriteLine("Index of r in demo2 is:" + demo2.IndexOf("r"));
            Console.WriteLine("A substring of demo1 is:" + demo1.Substring(demo1.IndexOf("l")));
            Console.WriteLine("Concatation using Plus:" + demo1 + demo2);
            Console.WriteLine("Using Special Characters: Hello \"Vikings\"World");
            Console.WriteLine("Using Special Characters Again:" + demo1+ "\"Vikings\""+demo2);
            Console.WriteLine("A new line:" + demo3);



        }
    }
}
