using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Arena
    {
        internal void fight (ConsoleMon fighterA, ConsoleMon fighterB)
        {
            fighterA.skills[0].UseOn(fighterB, fighterA);
            Console.WriteLine(fighterA.name + fighterB.name);

            fighterB.skills[0].UseOn(fighterA, fighterB);
            Console.WriteLine(fighterB.name + fighterA.name);
        }
        
    }

    
   
}


