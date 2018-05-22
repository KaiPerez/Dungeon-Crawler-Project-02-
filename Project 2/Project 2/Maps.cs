using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Maps
    {
        public bool GoNorth;
        public bool GoSouth;
        public bool GoWest;
        public bool GoEast;
        public bool IsMonster;
        public bool IsLoot;
        public bool IsSecret;

        public Maps(bool N, bool S, bool W, bool E, bool IsM, bool IsL, bool IsS)
        {
            GoNorth = N;
            GoSouth = S;
            GoWest = W;
            GoEast = E;
            IsMonster = IsM;
            IsLoot = IsL;
            IsSecret = IsS;
        }
        
        
        



    }
}

