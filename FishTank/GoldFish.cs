using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
     public class GoldFish : IFish
    {

       public string name { get; set; }
       public double foodRequired { get; set; }

       public GoldFish(string name)

        {
            this.name = name;
            foodRequired = 0.1;

        }
        
        
    }
}
