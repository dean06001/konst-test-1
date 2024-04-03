using konst_test_1;
using System;
namespace konst_test
{
    class Program
    {
        static void Main()
        {
            Bil1 bil = new Bil1("volvo", 2013, "svart", "500mil", 4);

            Console.WriteLine(bil.märke);
            Console.WriteLine(bil.årsmodell);
            Console.WriteLine(bil.färg);
            Console.WriteLine(bil.kört);
            Console.WriteLine(bil.sitplattser);

            Console.ReadLine();
        }
    }
}