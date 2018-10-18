using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft.Tests
{
    [TestFixture]
    public class ProviderControllerClass
    {
        private ProviderController sut;

        [SetUp]
        public void TestInit()
        {
            //Arrange
            this.sut = new ProviderController(new EnergyRepository());
        }

        [Test]
        public void TestRegisterFunction()
        {
            //ACT
            List<string> input = new List<string>() { "Pressure", "40", "100" };

            //Assert
            Assert.AreEqual("Successfully registered PressureProvider", sut.Register(input));
        }

        [Test]
        public void TestEntitiesCount()
        {
            //ACT
            List<string> input = new List<string>() { "Pressure", "40", "100" };
            sut.Register(input);

            //Assert
            Assert.AreEqual(1, sut.Entities.Count);
        }

        [Test]
        public void TestRepairByDouble()
        {
            //ACT
            List<string> input = new List<string>() { "Pressure", "40", "100" };
            sut.Register(input);

            //Assert
            Assert.AreEqual("Providers were repaired by 20", sut.Repair(20));
        }

        [Test]
        public void TestRegisterFunctionShouldReturnEx()
        {
            //ACT
            List<string> input = new List<string>() { "Pressure", "Hah", "100" };

            //Assert
            Assert.Throws<FormatException>(() => sut.Register(input));
        }

        [Test]
        public void TestProduceMethod()
        {
            List<string> input = new List<string>() { "Pressure", "40", "100" };
            sut.Register(input);
            
            sut.Produce();
            

            Assert.AreEqual("100", sut.TotalEnergyProduced);
        }

        [Test]
        public void TestProduceMethodShouldReturnEx()
        {
            List<string> input = new List<string>() { "Pressure", "40", "100" };
            

            Assert.Throws<Exception>(() => sut.Produce());
        }
    }
}
