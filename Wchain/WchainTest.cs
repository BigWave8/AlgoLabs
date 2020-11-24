using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Wchain
{
    [TestFixture]
    class WchainTest
    {
        [Test]
        public void Algorithm_TenWords_Expected6()
        {
            string pathTest = @"D:\projects\Algo\Wchain\wchain_test1.txt";
            Launcher.WordsChain = new Dictionary<string, int>();
            Launcher.Words = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(6, Launcher.Answer);
        }
        [Test]
        public void Algorithm_FiveWords_Expected5()
        {
            string pathTest = @"D:\projects\Algo\Wchain\wchain_test2.txt";
            Launcher.WordsChain = new Dictionary<string, int>();
            Launcher.Words = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(4, Launcher.Answer);
        }
        [Test]
        public void Algorithm_ThreeWords_Expected1()
        {
            string pathTest = @"D:\projects\Algo\Wchain\wchain_test3.txt";
            Launcher.WordsChain = new Dictionary<string, int>();
            Launcher.Words = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(1, Launcher.Answer);
        }
        [Test]
        public void Algorithm_TenWords_Expected10()
        {
            string pathTest = @"D:\projects\Algo\Wchain\wchain_test4.txt";
            Launcher.WordsChain = new Dictionary<string, int>();
            Launcher.Words = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(10, Launcher.Answer);
        }
        [Test]
        public void Algorithm_EightWords_Expected2()
        {
            string pathTest = @"D:\projects\Algo\Wchain\wchain_test5.txt";
            Launcher.WordsChain = new Dictionary<string, int>();
            Launcher.Words = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(2, Launcher.Answer);
        }
    }
}
