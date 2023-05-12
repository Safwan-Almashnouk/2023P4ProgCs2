using Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Skill
    {

        public int damage;
        public int energyCost;
        public string name;
        internal Elements element;


        internal void UseOn(ConsoleMon tarrget, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            tarrget.TakeDamage(damage);

            if (tarrget.weakness == element)
            {
                tarrget.TakeDamage(damage/2);
            }
        }
    }
    }

