using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Skill
    {

        public int damage;
        public int energyCost;
        public string name;


        internal void UseOn(ConsoleMon tarrget, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            tarrget.TakeDamage(damage);
        }
    }
    }

