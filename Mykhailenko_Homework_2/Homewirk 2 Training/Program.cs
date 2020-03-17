using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homewirk_2_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = File.ReadAllText("INPUT.TXT").Split(' ').Select(i => (long.Parse(i)))./*OrderBy(i => i).*/ToArray();







            string output = (input == input.Reverse())?"YES":"NO";


            //double vol = input[0] * input[1] * input[2];


            File.WriteAllText("OUTPUT.TXT", output);
        }
    }
}
