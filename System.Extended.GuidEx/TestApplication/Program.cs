using System;

namespace Test.Application.GuidEx
{
    class Program
    {
        static void Main()
        {
            const string g = "065afd82-c667-4d85-9949-f9db33056ef0";
            var l = new Guid(g);
            Console.WriteLine(l.ToString());
            var ex = new System.GuidEx(l);
            Console.WriteLine(ex.ToString());
            Console.WriteLine(ex.Version);

            var ex2 = new System.GuidEx("Potatis", "Månsken");
            Console.WriteLine(ex2.ToString());
            Console.WriteLine(ex2.Version);

            var ex3 = new System.GuidEx(g);
            Console.WriteLine(ex3.ToString());
            Console.WriteLine(ex3.Version);

            var ex4 = new System.GuidEx(g + g);
            Console.WriteLine(ex4.ToString());
            Console.WriteLine(ex4.Version);

            Console.ReadKey();
        }
    }
}
