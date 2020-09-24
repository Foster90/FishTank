using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class Tank
    {
        public List<IFish> fishList;

        public Tank()
        {

           fishList = new List<IFish>();

        }

        public void AddFish(IFish fish)
        {
            fishList.Add(fish);
        }


        public double Feed()
        {

            double result = 0.0;
            fishList.ForEach(x => result += x.foodRequired);
            return result;

        }



    }
}
