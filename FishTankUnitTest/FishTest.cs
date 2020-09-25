using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;

namespace FishTankUnitTest
{
    [TestClass]
    public class FishTest
    {

        [TestMethod]
        public void GoldFishTest()
        {

            GoldFish goldFish = new GoldFish("Jot");

            Assert.AreEqual("Jot", goldFish.name);
            Assert.AreEqual(0.1, goldFish.foodRequired);

        }

        [TestMethod]
        public void BabelFishTest()
        {


            BabelFish babelFish = new BabelFish("Dot");

            Assert.AreEqual("Dot", babelFish.name);
            Assert.AreEqual(0.3, babelFish.foodRequired);

        }

        [TestMethod]
        public void AngelFishTest()
        {

            AngelFish angelFish = new AngelFish("Spot");

            Assert.AreEqual("Spot", angelFish.name);
            Assert.AreEqual(0.2, angelFish.foodRequired);


        }
             
    }
}
