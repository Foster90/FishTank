using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
   public interface IFish
    {
         string name { get; set; }
         double foodRequired { get; set; }

    }
}
