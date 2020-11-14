using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Lab3
{
    [TestFixture]
    class GovernTest
    {
        [Test]
        public void Algorithm_TwoGoverns()
        {
            Launcher.Documents = new Dictionary<string, LinkedList<string>>
            {
                { "visa", new LinkedList<string>(new List<string> { "foreignpassport" }) },
                { "foreignpassport", new LinkedList<string>() }
            };
            Launcher.DocumentsUsed = new Dictionary<string, bool>
            {
                { "visa", false },
                { "foreignpassport", false }
            };
            Launcher.Answer = new List<string>();

            Launcher.Algorithm();
            Assert.AreEqual("foreignpassport", Launcher.Answer[0]);
            Assert.AreEqual("visa", Launcher.Answer[1]);
        }
        [Test]
        public void Algorithm_EightGoverns()
        {
            Launcher.Documents = new Dictionary<string, LinkedList<string>>
            {
                { "visa", new LinkedList<string>(new List<string> { "foreignpassport", "hotel", "bankstatement" }) },
                { "bankstatement", new LinkedList<string>(new List<string> { "nationalpassport" }) },
                { "hotel", new LinkedList<string>(new List<string> { "creditcard" }) },
                { "creditcard", new LinkedList<string>(new List<string> { "nationalpassport" }) },
                { "nationalpassport", new LinkedList<string>(new List<string> { "birthcertificate" }) },
                { "foreignpassport", new LinkedList<string>(new List<string> { "nationalpassport", "militarycertificate" }) },
                { "militarycertificate", new LinkedList<string>(new List<string> { "nationalpassport" }) },
                { "birthcertificate", new LinkedList<string>() }
            };
            Launcher.DocumentsUsed = new Dictionary<string, bool>
            {
                { "visa", false },
                { "bankstatement", false },
                { "hotel", false },
                { "creditcard", false },
                { "nationalpassport", false },
                { "foreignpassport", false },
                { "militarycertificate", false },
                { "birthcertificate", false }
            };
            Launcher.Answer = new List<string>();

            Launcher.Algorithm();
            Assert.AreEqual("birthcertificate", Launcher.Answer[0]);
            Assert.AreEqual("nationalpassport", Launcher.Answer[1]);
            Assert.AreEqual("militarycertificate", Launcher.Answer[2]);
            Assert.AreEqual("foreignpassport", Launcher.Answer[3]);
            Assert.AreEqual("creditcard", Launcher.Answer[4]);
            Assert.AreEqual("hotel", Launcher.Answer[5]);
            Assert.AreEqual("bankstatement", Launcher.Answer[6]);
            Assert.AreEqual("visa", Launcher.Answer[7]);
        }
        [Test]
        public void Algorithm_ElevenGoverns()
        {
            Launcher.Documents = new Dictionary<string, LinkedList<string>>
            {
                { "a", new LinkedList<string>(new List<string> { "b" }) },
                { "b", new LinkedList<string>(new List<string> { "c" }) },
                { "c", new LinkedList<string>(new List<string> { "d" }) },
                { "d", new LinkedList<string>(new List<string> { "e" }) },
                { "e", new LinkedList<string>(new List<string> { "f" }) },
                { "f", new LinkedList<string>(new List<string> { "g" }) },
                { "g", new LinkedList<string>(new List<string> { "h" }) },
                { "h", new LinkedList<string>() },
                { "x", new LinkedList<string>(new List<string> { "y" }) },
                { "y", new LinkedList<string>(new List<string> { "z" }) },
                { "z", new LinkedList<string>() }
            };
            Launcher.DocumentsUsed = new Dictionary<string, bool>
            {
                { "a", false },
                { "b", false },
                { "c", false },
                { "d", false },
                { "e", false },
                { "f", false },
                { "g", false },
                { "h", false },
                { "x", false },
                { "y", false },
                { "z", false }
            };
            Launcher.Answer = new List<string>();

            Launcher.Algorithm();
            Assert.AreEqual("h", Launcher.Answer[0]);
            Assert.AreEqual("g", Launcher.Answer[1]);
            Assert.AreEqual("f", Launcher.Answer[2]);
            Assert.AreEqual("e", Launcher.Answer[3]);
            Assert.AreEqual("d", Launcher.Answer[4]);
            Assert.AreEqual("c", Launcher.Answer[5]);
            Assert.AreEqual("b", Launcher.Answer[6]);
            Assert.AreEqual("a", Launcher.Answer[7]);
            Assert.AreEqual("z", Launcher.Answer[8]);
            Assert.AreEqual("y", Launcher.Answer[9]);
            Assert.AreEqual("x", Launcher.Answer[10]);
        }
        [Test]
        public void ReadWithFile_GovertTest1()
        {
            string path = @"D:\projects\Algo\Lab3\govern_test1.txt";
            Launcher.Documents = new Dictionary<string, LinkedList<string>>();
            Launcher.DocumentsUsed = new Dictionary<string, bool>();

            Launcher.ReadWithFile(path);
            Assert.AreEqual("foreignpassport", Launcher.Documents["visa"].First.Value);
            Assert.IsNull(Launcher.Documents["foreignpassport"].First);

            Assert.AreEqual(false, Launcher.DocumentsUsed["visa"]);
            Assert.IsFalse(Launcher.DocumentsUsed["foreignpassport"]);

            Assert.IsTrue(Launcher.Documents.ContainsKey("visa"));
            Assert.IsTrue(Launcher.DocumentsUsed.ContainsKey("foreignpassport"));
            Assert.IsFalse(Launcher.Documents.ContainsKey("hotel"));
        }
        [Test]
        public void ReadWithFile_GovertTest2()
        {
            string path = @"D:\projects\Algo\Lab3\govern_test2.txt";
            Launcher.Documents = new Dictionary<string, LinkedList<string>>();
            Launcher.DocumentsUsed = new Dictionary<string, bool>();

            Launcher.ReadWithFile(path);
            Assert.AreEqual("foreignpassport", Launcher.Documents["visa"].First.Value);
            Assert.AreEqual("bankstatement", Launcher.Documents["visa"].Last.Value);
            Assert.IsNull(Launcher.Documents["birthcertificate"].First);

            Assert.AreEqual(false, Launcher.DocumentsUsed["visa"]);
            Assert.IsFalse(Launcher.DocumentsUsed["foreignpassport"]);
            Assert.AreNotEqual(true, Launcher.DocumentsUsed["nationalpassport"]);
            Assert.IsFalse(Launcher.DocumentsUsed["birthcertificate"]);

            Assert.IsTrue(Launcher.Documents.ContainsKey("visa"));
            Assert.IsTrue(Launcher.DocumentsUsed.ContainsKey("foreignpassport"));
            Assert.IsTrue(Launcher.DocumentsUsed.ContainsKey("nationalpassport"));
            Assert.IsTrue(Launcher.DocumentsUsed.ContainsKey("birthcertificate"));
            Assert.IsFalse(Launcher.Documents.ContainsKey("abc"));
        }
        [Test]
        public void ReadWithFile_GovertTest3()
        {
            string path = @"D:\projects\Algo\Lab3\govern_test3.txt";
            Launcher.Documents = new Dictionary<string, LinkedList<string>>();
            Launcher.DocumentsUsed = new Dictionary<string, bool>();

            Launcher.ReadWithFile(path);
            Assert.AreEqual("b", Launcher.Documents["a"].First.Value);
            Assert.AreEqual("c", Launcher.Documents["b"].First.Value);
            Assert.AreEqual("d", Launcher.Documents["c"].First.Value);
            Assert.AreEqual("e", Launcher.Documents["d"].First.Value);
            Assert.AreEqual("f", Launcher.Documents["e"].First.Value);
            Assert.IsNull(Launcher.Documents["h"].First);
            Assert.AreEqual("y", Launcher.Documents["x"].First.Value);
            Assert.AreEqual("z", Launcher.Documents["y"].First.Value);
            Assert.IsNull(Launcher.Documents["z"].First);

            Assert.AreEqual(false, Launcher.DocumentsUsed["a"]);
            Assert.AreEqual(false, Launcher.DocumentsUsed["d"]);
            Assert.AreEqual(false, Launcher.DocumentsUsed["x"]);
            Assert.IsFalse(Launcher.DocumentsUsed["z"]);

            Assert.IsTrue(Launcher.Documents.ContainsKey("a"));
            Assert.IsTrue(Launcher.DocumentsUsed.ContainsKey("z"));
            Assert.IsFalse(Launcher.Documents.ContainsKey("r"));
        }
        [Test]
        public void ReadWithFile_GovertTest4()
        {
            string path = @"D:\projects\Algo\Lab3\govern_test4.txt";
            Launcher.Documents = new Dictionary<string, LinkedList<string>>();
            Launcher.DocumentsUsed = new Dictionary<string, bool>();

            Launcher.ReadWithFile(path);
            Assert.AreEqual("y", Launcher.Documents["x"].First.Value);
            Assert.AreEqual("z", Launcher.Documents["y"].First.Value);
            Assert.AreEqual("x", Launcher.Documents["z"].First.Value);

            Assert.AreEqual(false, Launcher.DocumentsUsed["x"]);
            Assert.IsFalse(Launcher.DocumentsUsed["z"]);

            Assert.IsTrue(Launcher.Documents.ContainsKey("x"));
            Assert.IsTrue(Launcher.DocumentsUsed.ContainsKey("y"));
            Assert.IsFalse(Launcher.Documents.ContainsKey("a"));
        }
    }
}
