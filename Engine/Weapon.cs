using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        // these lines were previously included but since we added 'Item' as a parent class 'HealingPotion' can inherit those properties and they are no longer neede here
        // public int ID { get; set; }
        // public string Name { get; set; } 
        // public string NamePlural { get; set; }  
       
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; } 

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
