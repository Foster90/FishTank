using Microsoft.VisualStudio.TestTools.UnitTesting;
using FishTank;
using System;
using System.Collections.Generic;
using System.Text;

namespace FishTankUnitTest
{
    [TestClass]
    public class TankTest
    {

        GoldFish goldFish;
        AngelFish angelFish;
        BabelFish babelFish;

        public TankTest()
        {
            goldFish = new GoldFish("Spot");
            angelFish = new AngelFish("Dot");
            babelFish = new BabelFish("Jot");
        }

        [TestMethod]
        public void AddOneFishToTank()
        {
            var tank = new Tank();

            tank.AddFish(goldFish);

            Assert.AreEqual(1, tank.fishList.Count);
        }

        [TestMethod]
        public void AddTwoFishToTank()
        {
            var tank = new Tank();

            tank.AddFish(goldFish);
            tank.AddFish(angelFish);
            Assert.AreEqual(2, tank.fishList.Count);

        }

        [TestMethod]
        public void AddThreeFishToTank()
        {
            var tank = new Tank();

            tank.AddFish(goldFish);
            tank.AddFish(angelFish);
            tank.AddFish(babelFish);
            Assert.AreEqual(3, tank.fishList.Count);


        }

        [TestMethod]
        public void TestGoldFishFeed()
        {
            var tank = new Tank();

            tank.AddFish(goldFish);
                                
            double expectedResult = 0.1;
            Assert.AreEqual(expectedResult, tank.Feed());
        }

        [TestMethod]
        public void TestAngelFishFeed()
        {
            var tank = new Tank();

            tank.AddFish(angelFish);           

            double expectedResult = 0.2;
            Assert.AreEqual(expectedResult, tank.Feed());

        }

        [TestMethod]
        public void TestBabelFishFeed()
        {
            var tank = new Tank();

            tank.AddFish(babelFish);

            double expectedResult = 0.3;
            Assert.AreEqual(expectedResult, tank.Feed());

        }

        [TestMethod]
        public void TestAllFishFeed()
        {
            var tank = new Tank();

            tank.AddFish(babelFish);
            tank.AddFish(angelFish);
            tank.AddFish(goldFish);

            double expectedResult = 0.3 + 0.2 + 0.1;
            Assert.AreEqual(expectedResult, tank.Feed());

        }
    }
}


