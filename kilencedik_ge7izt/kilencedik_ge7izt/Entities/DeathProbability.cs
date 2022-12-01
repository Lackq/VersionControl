using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kilencedik_ge7izt.Entities
{
    class DeathProbability
    {
        public int BirthYear { get; set; }
        public Gender Gender { get; set; }
        public bool IsAlive { get; set; }

        public DeathProbability()
        {
            IsAlive = true;
        }
    }
}
