using Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class ConsoleMonFactory
    {
       
        internal void Load(string datatype)
        {
            string[] lines = File.ReadAllLines(datatype);
            foreach (string line in lines)
            {
                ConsoleMon datamon = new ConsoleMon();
                Console.WriteLine(line);
                string[] typesplit = line.Split('|');
                string[] consolemonData = typesplit[0].Split(",");
                foreach (string type in typesplit)
                {
                    Console.WriteLine(type); 
                }
            }

            
            
        }
        internal List<ConsoleMon>  LoadJson(string datatype)
        {
           string json = File.ReadAllText(datatype);
           Console.WriteLine(json);
           List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
           Console.WriteLine(templates[0].name);
           return templates;
        }

        internal Skill CopySkill(Skill copyfrom)
        {

            Skill copyResult = new Skill();
            copyResult.name = copyfrom.name;
            copyResult.damage= copyfrom.damage;
            copyResult.element= copyfrom.element;
            copyResult.energyCost= copyfrom.energyCost;
            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
           ConsoleMon copyResult = new ConsoleMon();
           copyResult.name = copyFrom.name;
           copyResult.health= copyFrom.health;
           copyResult.energy = copyFrom.energy;
           copyResult.skills = new List<Skill>();
           copyResult.weakness= copyFrom.weakness;
            foreach (Skill skill in copyFrom.skills)
            {
               
                copyResult.skills.Add(CopySkill(skill));
                
                
            }

           return copyResult;

        }

    }
}
