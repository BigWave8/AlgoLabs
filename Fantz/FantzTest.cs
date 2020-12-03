using NUnit.Framework;

namespace Fantz
{
    [TestFixture]
    class FantzTest
    {
        [Test]
        public void Algorithm_5N_Expected3()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test1.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(3, Launcher.Answer);
        }
        [Test]
        public void Algorithm_5N_Expected1()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test2.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(1, Launcher.Answer);
        }
        [Test]
        public void Algorithm_5N_V2_Expected3()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test3.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(3, Launcher.Answer);
        }
        [Test]
        public void Algorithm_7N_Expected5()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test4.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(5, Launcher.Answer);
        }
        [Test]
        public void Algorithm_1N_Expected510()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test5.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(10, Launcher.Answer);
        }
        [Test]
        public void Algorithm_1N_ExpectedMinus1()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test6.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(-1, Launcher.Answer);
        }
        [Test]
        public void Algorithm_2N_ExpectedMinus1()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test7.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(5, Launcher.Answer);
        }
        [Test]
        public void Algorithm_4N_ExpectedMinus1()
        {
            string pathTest = @"D:\projects\Algo\Fantz\fantz_test8.txt";
            Launcher.Bits = Launcher.ReadWithFile(pathTest);

            Launcher.Answer = Launcher.Algorithm();

            Assert.AreEqual(-1, Launcher.Answer);
        }
    }
}
