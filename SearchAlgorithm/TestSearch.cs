using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SearchAlgorithm
{
    [TestFixture]
    class TestSearch
    {
        [Test]
        public void BruteForceAlgorithm_DDABA_Expected14()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test1.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(14, Launcher.Answers[0]);
        }
        [Test]
        public void BruteForceAlgorithm_5_Expected5()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test2.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(4, Launcher.Answers[0]);
        }
        [Test]
        public void BruteForceAlgorithm_CAB_Expected2_5_8_11()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test3.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(2, Launcher.Answers[0]);
            Assert.AreEqual(5, Launcher.Answers[1]);
            Assert.AreEqual(8, Launcher.Answers[2]);
            Assert.AreEqual(11, Launcher.Answers[3]);
        }
        [Test]
        public void BruteForceAlgorithm_ADACR_ExpectedMinus1()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test4.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(-1, Launcher.Answers[0]);
        }
        [Test]
        public void BruteForceAlgorithm_AAAAB_Expected5()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test5.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(5, Launcher.Answers[0]);
        }
        ///////////////////////////////////////////
        [Test]
        public void BoyerMooreAlgorithm_DDABA_Expected14()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test1.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(14, Launcher.Answers[0]);
        }
        [Test]
        public void BoyerMooreAlgorithm_5_Expected5()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test2.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(4, Launcher.Answers[0]);
        }
        [Test]
        public void BoyerMooreAlgorithm_CAB_Expected2_5_8_11()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test3.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(2, Launcher.Answers[0]);
            Assert.AreEqual(5, Launcher.Answers[1]);
            Assert.AreEqual(8, Launcher.Answers[2]);
            Assert.AreEqual(11, Launcher.Answers[3]);
        }
        [Test]
        public void BoyerMooreAlgorithm_ADACR_ExpectedMinus1()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test4.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(-1, Launcher.Answers[0]);
        }
        [Test]
        public void BoyerMooreAlgorithm_AAAAB_Expected5()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test5.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(5, Launcher.Answers[0]);
        }
    }
}
