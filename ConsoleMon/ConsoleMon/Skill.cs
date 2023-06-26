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

        public int damage { get; set; }
        public int energyCost { get; set; }
        public string name { get; set; }
        internal Elements element { get; set; }

        public Skill()
        {

        }

        public Skill(int damage, int energyCost, string name, Elements element)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = element;
        }

        public void UseOn(ConsoleMon tarrget, ConsoleMon caster)
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

