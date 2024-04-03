using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konst_test_1
{
    internal class Bil1
    {
        public string märke;
        public int årsmodell;
        public string färg;
        public string kört;
        public int sitplattser;

        public Bil1(string Märke, int år, string color, string kör, int plattser)
        {
            märke = Märke;
            årsmodell = år;
            färg = color;
            kört = kör;
            sitplattser = plattser;
        }
    }
}
