using CarPark;
using NUnit.Framework;

namespace CarParkTests
{
    [TestFixture]
    public class CarParkEscapeTests
    {
        public static CarParkEscape CarParkEscape()
        {
            return new CarParkEscape();
        }
        
        [Test]
        public void BasicTest1()
        {
            
            int[,] carpark = { { 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "L4", "D1", "R4" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest2()
        {
            
            int[,] carpark = { { 2, 0, 0, 1, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "R3", "D2", "R1" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest3()
        {
            
            int[,] carpark = { { 0, 2, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "R3", "D3" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest4()
        {
            
            int[,] carpark = { { 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest5()
        {
            
            int[,] carpark = { { 0, 0, 0, 0, 2 } };
            string[] result = { };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest6()
        {

            int[,] carpark = { { 2, 0, 0, 0, 1 },
                                           { 1, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 1 },
                                           { 0, 0, 0, 0, 1 },
                                           { 0, 0, 0, 0, 1 },
                                           { 0, 0, 0, 0, 0 } };
            string[] result = { "R4", "D1", "L4", "D1", "R4", "D3" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest7()
        {
            int[,] carpark = { { 1, 0, 0, 0, 2 },
                                           { 1, 0, 0, 0, 0 },
                                           { 0, 0, 1, 0, 0 },
                                           { 0, 0, 0, 0, 1 },
                                           { 1, 0, 0, 0, 0 },
                                           { 0, 0, 0, 0, 0 } };
            string[] result = { "L4","D2","R2","D1","R2","D1","L4","D1","R4" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest8()
        {
            int[,] carpark = { { 1, 0, 0, 0, 2 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };
            string[] result = { "L4", "D2", "R2", "D1", "R2", "D1", "L4", "D1", "R2","D1", "R2" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest9()
        {
            int[,] carpark = 
                { { 1, 0, 0, 0, 2 },
                  { 0, 1, 0, 0, 0 },
                  { 0, 0, 1, 0, 0 },
                  { 0, 0, 0, 1, 0 },
                  { 0, 0, 0, 0, 1 },
                  { 0, 0, 0, 1, 0 },
                  { 0, 0, 1, 0, 0 },
                  { 0, 1, 0, 0, 0 },
                  { 1, 0, 0, 0, 0 },
                  { 0, 0, 0, 0, 0 }
            };
            string[] result = { "L4", "D1", "R1", "D1", "R1", "D1", "R1", "D1","R1","D1","L1", "D1", "L1", "D1", "L1", "D1", "L1","D1", "R4" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest10()
        {
            int[,] carpark = 
              { { 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0 } };
            string[] result = { "L4", "D1", "R4", "D1", "L4", "D2", "R4", "D1" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }

        [Test]
        public void BasicTest11()
        {
            int[,] carpark =
            { { 1, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0 },
                { 1, 0, 0, 0, 0 } };
            string[] result = { "L4", "D1", "R4", "D1", "L4", "D2", "R4", "D2", "L4", "D1", "R2", "D1", "R4" };
            Assert.AreEqual(result, CarParkEscape().Escape(carpark));
        }
    }
}
