using System.Collections.Generic;
using NUnit.Framework;

namespace Hamsters
{
    [TestFixture]
    class HamstersTest
    {
        [Test]
        public void Algorithm_ThreeHamsters_ExpectedTwo()
        {
            int hamsterCounter = 0;
            int quantityEat = 7;
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 1, Greed = 2 },
                new Hamster() { Hunger = 2, Greed = 2 },
                new Hamster() { Hunger = 3, Greed = 1 }
            };

            Launcher.Algorithm(list, ref hamsterCounter, quantityEat);
            Assert.AreEqual(2, hamsterCounter);
        }
        [Test]
        public void Algorithm_FourHamsters_ExpectedThree()
        {
            int hamsterCounter = 0;
            int quantityEat = 19;
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 5, Greed = 0 },
                new Hamster() { Hunger = 2, Greed = 2 },
                new Hamster() { Hunger = 1, Greed = 4 },
                new Hamster() { Hunger = 5, Greed = 1 }
            };

            Launcher.Algorithm(list, ref hamsterCounter, quantityEat);
            Assert.AreEqual(3, hamsterCounter);
        }
        [Test]
        public void Algorithm_TwoHamsters_ExpectedOne()
        {
            int hamsterCounter = 0;
            int quantityEat = 2;
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 1, Greed = 50000 },
                new Hamster() { Hunger = 1, Greed = 60000 }
            };

            Launcher.Algorithm(list, ref hamsterCounter, quantityEat);
            Assert.AreEqual(1, hamsterCounter);
        }
        [Test]
        public void Algorithm_FiveHamsters_ExpectedThree()
        {
            int hamsterCounter = 0;
            int quantityEat = 9;
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 5, Greed = 4 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 4, Greed = 5 }
            };

            Launcher.Algorithm(list, ref hamsterCounter, quantityEat);
            Assert.AreEqual(3, hamsterCounter);
        }
        [Test]
        public void Algorithm_EightHamsters_ExpectedThree()
        {
            int hamsterCounter = 0;
            int quantityEat = 12;
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 1, Greed = 3 },
                new Hamster() { Hunger = 1, Greed = 4 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 5 },
                new Hamster() { Hunger = 1, Greed = 2 },
                new Hamster() { Hunger = 2, Greed = 1 },
                new Hamster() { Hunger = 3, Greed = 3 },
                new Hamster() { Hunger = 2, Greed = 2 }
            };

            Launcher.Algorithm(list, ref hamsterCounter, quantityEat);
            Assert.AreEqual(3, hamsterCounter);
        }
        [Test]
        public void Algorithm_ElevenHamsters_ExpectedTen()
        {
            int hamsterCounter = 0;
            int quantityEat = 100;
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 }
            };

            Launcher.Algorithm(list, ref hamsterCounter, quantityEat);
            Assert.AreEqual(10, hamsterCounter);
        }
        [Test]
        public void Algorithm_TenHamsters_ExpectedNine()
        {
            int hamsterCounter = 0;
            int quantityEat = 90;
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 },
                new Hamster() { Hunger = 1, Greed = 1 }
            };

            Launcher.Algorithm(list, ref hamsterCounter, quantityEat);
            Assert.AreEqual(9, hamsterCounter);
        }
        [Test]
        public void QuickSelect_FourHamsters()
        {
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 1, Greed = 2 },
                new Hamster() { Hunger = 4, Greed = 4 },
                new Hamster() { Hunger = 6, Greed = 0 },
                new Hamster() { Hunger = 2, Greed = 6 }
            };

            Selecter.QuickSelect(list, 0);
            Assert.AreEqual(new Hamster() { Hunger = 1, Greed = 2 }, list[0]);
            Selecter.QuickSelect(list, 1);
            Assert.AreEqual(new Hamster() { Hunger = 6, Greed = 0 }, list[1]);
            Selecter.QuickSelect(list, 2);
            Assert.AreEqual(new Hamster() { Hunger = 4, Greed = 4 }, list[2]);
            Selecter.QuickSelect(list, 3);
            Assert.AreEqual(new Hamster() { Hunger = 2, Greed = 6 }, list[3]);
        }
        [Test]
        public void QuickSelect_ThreeHamsters()
        {
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 5, Greed = 3 },
                new Hamster() { Hunger = 2, Greed = 2 },
                new Hamster() { Hunger = 1, Greed = 8 }
            };

            Selecter.QuickSelect(list, 0);
            Assert.AreEqual(new Hamster() { Hunger = 1, Greed = 8 }, list[0]);
            Selecter.QuickSelect(list, 1);
            Assert.AreEqual(new Hamster() { Hunger = 5, Greed = 3 }, list[1]);
            Selecter.QuickSelect(list, 2);
            Assert.AreEqual(new Hamster() { Hunger = 1, Greed = 8 }, list[2]);
        }
        [Test]
        public void QuickSelect_SixHamsters()
        {
            List<Hamster> list = new List<Hamster>
            {
                new Hamster() { Hunger = 0, Greed = 6 },
                new Hamster() { Hunger = 10, Greed = 0 },
                new Hamster() { Hunger = 5, Greed = 3 },
                new Hamster() { Hunger = 6, Greed = 2 },
                new Hamster() { Hunger = 3, Greed = 5 },
                new Hamster() { Hunger = 1, Greed = 1 }
            };

            Selecter.QuickSelect(list, 0);
            Assert.AreEqual(new Hamster() { Hunger = 0, Greed = 6 }, list[0]);
            Selecter.QuickSelect(list, 1);
            Assert.AreEqual(new Hamster() { Hunger = 0, Greed = 6 }, list[1]);
            Selecter.QuickSelect(list, 2);
            Assert.AreEqual(new Hamster() { Hunger = 6, Greed = 2 }, list[2]);
            Selecter.QuickSelect(list, 3);
            Assert.AreEqual(new Hamster() { Hunger = 5, Greed = 3 }, list[3]);
            Selecter.QuickSelect(list, 4);
            Assert.AreEqual(new Hamster() { Hunger = 3, Greed = 5 }, list[4]);
            Selecter.QuickSelect(list, 5);
            Assert.AreEqual(new Hamster() { Hunger = 0, Greed = 6 }, list[5]);
        }
        [Test]
        public void SumOfEat_1And2()
        {
            List<Hamster> list = new List<Hamster>();

            list.Add(new Hamster() { Hunger = 1, Greed = 2 });

            Assert.AreEqual(1, list[0].SumOfEat(0));
            Assert.AreEqual(3, list[0].SumOfEat(1));
            Assert.AreEqual(5, list[0].SumOfEat(2));
            Assert.AreEqual(7, list[0].SumOfEat(3));
            Assert.AreEqual(9, list[0].SumOfEat(4)); 
        }
        [Test]
        public void SumOfEat_3And7()
        {
            List<Hamster> list = new List<Hamster>();

            list.Add(new Hamster() { Hunger = 3, Greed = 7 });

            Assert.AreEqual(3, list[0].SumOfEat(0));
            Assert.AreEqual(10, list[0].SumOfEat(1));
            Assert.AreEqual(17, list[0].SumOfEat(2));
            Assert.AreEqual(24, list[0].SumOfEat(3));
            Assert.AreEqual(31, list[0].SumOfEat(4));
        }
        [Test]
        public void SumOfEat_2And1()
        {
            List<Hamster> list = new List<Hamster>();

            list.Add(new Hamster() { Hunger = 2, Greed = 1 });

            Assert.AreEqual(2, list[0].SumOfEat(0));
            Assert.AreEqual(3, list[0].SumOfEat(1));
            Assert.AreEqual(4, list[0].SumOfEat(2));
            Assert.AreEqual(5, list[0].SumOfEat(3));
            Assert.AreEqual(6, list[0].SumOfEat(4));
        }
        [Test]
        public void SumOfEat_4And5()
        {
            List<Hamster> list = new List<Hamster>();

            list.Add(new Hamster() { Hunger = 4, Greed = 5 });

            Assert.AreEqual(4, list[0].SumOfEat(0));
            Assert.AreEqual(9, list[0].SumOfEat(1));
            Assert.AreEqual(14, list[0].SumOfEat(2));
            Assert.AreEqual(19, list[0].SumOfEat(3));
            Assert.AreEqual(24, list[0].SumOfEat(4));
        }
    }
}