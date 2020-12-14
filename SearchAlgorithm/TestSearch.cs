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
        [Test]
        public void BruteForceAlgorithm_aaaaabbbbb_Expected0_1_2()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test6.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(1, Launcher.Answers[1]);
            Assert.AreEqual(2, Launcher.Answers[2]);
        }
        [Test]
        public void BruteForceAlgorithm_rfgdgekesefes_Expected9()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test7.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(9, Launcher.Answers[0]);
        }
        [Test]
        public void BruteForceAlgorithm_rfgdgekesfes_ExpectedMinus1()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test8.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(-1, Launcher.Answers[0]);
        }
        [Test]
        public void BruteForceAlgorithm_rfgdgekesefesddefes_Expected9_15()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test9.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(9, Launcher.Answers[0]);
            Assert.AreEqual(15, Launcher.Answers[1]);
        }
        [Test]
        public void BruteForceAlgorithm_rfgdgekesefesekedredsekerdsdsa_Expected21()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test10.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(21, Launcher.Answers[0]);
        }
        [Test]
        public void BruteForceAlgorithm_efes_Expected0()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test11.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
        }
        [Test]
        public void BruteForceAlgorithm_efesseffereefesfesfsefsfesfefsefefsefefesfsfse_Expected0_11_37()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test12.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(11, Launcher.Answers[1]);
            Assert.AreEqual(37, Launcher.Answers[2]);
        }
        [Test]
        public void BruteForceAlgorithm_efesfessrefdergefsdfefesfdgsef_Expected0_20()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test13.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(20, Launcher.Answers[1]);
        }
        [Test]
        public void BruteForceAlgorithm_efefefesefes_Expected0_2()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test14.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BruteForceAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(2, Launcher.Answers[1]);
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
        public void BoyerMooreAlgorithm_aaaaabbbbb_Expected0_1_2()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test6.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(1, Launcher.Answers[1]);
            Assert.AreEqual(2, Launcher.Answers[2]);
        }
        [Test]
        public void BoyerMooreAlgorithm_rfgdgekesefes_Expected9()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test7.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(9, Launcher.Answers[0]);
        }
        [Test]
        public void BoyerMooreAlgorithm_rfgdgekesfes_ExpectedMinus1()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test8.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(-1, Launcher.Answers[0]);
        }
        [Test]
        public void BoyerMooreAlgorithm_rfgdgekesefesddefes_Expected9_15()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test9.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(9, Launcher.Answers[0]);
            Assert.AreEqual(15, Launcher.Answers[1]);
        }
        [Test]
        public void BoyerMooreAlgorithm_rfgdgekesefesekedredsekerdsdsa_Expected21()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test10.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(21, Launcher.Answers[0]);
        }
        [Test]
        public void BoyerMooreAlgorithm_efes_Expected0()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test11.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
        }
        [Test]
        public void BoyerMooreAlgorithm_efesseffereefesfesfsefsfesfefsefefsefefesfsfse_Expected0_11_37()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test12.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(11, Launcher.Answers[1]);
            Assert.AreEqual(37, Launcher.Answers[2]);
        }
        [Test]
        public void BoyerMooreAlgorithm_efesfessrefdergefsdfefesfdgsef_Expected0_20()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test13.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(20, Launcher.Answers[1]);
        }
        [Test]
        public void BoyerMooreAlgorithm_efefefesefes_Expected0_2()
        {
            string pathTest = @"D:\projects\Algo\SearchAlgorithm\string_test14.txt";
            Launcher.ReadWithFile(pathTest);

            Launcher.Answers = (int[])Launcher.BoyerMooreAlgorithm().ToArray().Clone();

            Assert.AreEqual(0, Launcher.Answers[0]);
            Assert.AreEqual(2, Launcher.Answers[1]);
        }
    }
}
