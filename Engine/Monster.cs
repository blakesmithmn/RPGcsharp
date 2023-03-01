using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        // these lines were previously included but since we added 'Item' as a parent class 'HealingPotion' can inherit those properties and they are no longer neede here

        // public int MaximumHitPoints { get; set; }
        // public int CurrentHitPoints { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
    }
}
