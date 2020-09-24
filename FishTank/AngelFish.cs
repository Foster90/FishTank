using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class AngelFish : IFish
    {
                 
        public string name { get; set; }
        public double foodRequired { get; set; }

        public AngelFish(string name)

        {
            this.name = name;
            foodRequired = 0.2;

        }


    }
}


