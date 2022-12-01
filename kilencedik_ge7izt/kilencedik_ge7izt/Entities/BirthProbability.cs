using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kilencedik_ge7izt.Entities
{
    class BirthProbability
    {
        public int BirthYear { get; set; }
        public int NbrOfChildren { get; set; }
        public bool IsAlive { get; set; }

        public BirthProbability()
        {
            IsAlive = true;
        }
    }
}
