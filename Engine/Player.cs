﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        // these lines were previously included but since we added 'Item' as a parent class 'HealingPotion' can inherit those properties and they are no longer neede here

        // public int CurrentHitPoints { get; set; }
        //  public int MaximumHitPoints { get; set; }
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }  

    }
}
