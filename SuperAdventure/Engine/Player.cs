using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Engine
{
    //creating my player with a class called Player; this clais (like class monster) is pulling from base class, LivingCreature
    public class Player : LivingCreature
    {
        //my player has these properties
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

    }
}
