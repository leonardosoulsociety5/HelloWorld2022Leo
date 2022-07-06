using NUnit.Framework;

namespace Tests {
    public class Tutorial1Tests {
        // Criteria 0: Sum returns the sum of the two arguments.
        [Test]
        public void TestHelloWorld () {
            Names gs = new Names ();
            Assert.IsTrue (gs.SayHello () == "Hello World");
        }
        // Criteria 1: Sum returns the sum of the two arguments.
        [TestCase (12, 20)]
        [TestCase (30, 40)]
        [TestCase (10, 0)]
        public void TestGreaterThan (int a, int b) {
            Numbers gs = new Numbers {
                memberA = a,
                memberB = b
            };
            bool gt = gs.GreaterThan ();
            // Use the Assert class to test conditions
            Assert.True (gt == (a > b));
        }

        // Add your name to the argument passed in.
        [TestCase ("Not A Name")]
        [TestCase ("205")]
        public void TestMyName (string a) {
            Names gs = new Names {
                name = a
            };
            // Use the Assert class to test conditions
            Assert.IsFalse (gs.MyName ());
            gs.myName = a;
            Assert.IsTrue (gs.MyName ());
        }

        // Criteria 1: Sum returns the sum of the two arguments.
        [TestCase (12, 20)]
        [TestCase (25, 45)]
        [TestCase (-10, 0)]
        public void TestSumTwoArguments (int a, int b) {
            Numbers gs = new Numbers ();
            int sum = gs.SumTwoArguments (a, b);
            // Use the Assert class to test conditions
            Assert.AreEqual (sum, a + b);
        }

        // Criteria 2: Sum returns the sum of the two member variables.
        [TestCase (12, 30)]
        [TestCase (10, 50)]
        [TestCase (-10, 100)]
        public void TestSumTwoMembers (int a, int b) {
            Numbers gs = new Numbers {
                memberA = a,
                memberB = b

            };
            int sum = gs.SumTwoIntMembers ();
            // Use the Assert class to test conditions
            Assert.AreEqual (sum, a + b);
        }

        // Add your name to the argument passed in.
        [TestCase ("Hi there, ", "Joey")]
        [TestCase ("Hola, ", "Jessica")]
        public void TestUseGreeting (string a, string b) {
            Names gs = new Names {
                name = b
            };
            // Use the Assert class to test conditions
            Assert.IsTrue (a + b == gs.UseGreeting (a));
        }

    }
}