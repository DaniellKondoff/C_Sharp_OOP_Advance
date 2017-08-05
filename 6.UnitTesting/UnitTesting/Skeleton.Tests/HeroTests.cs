using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[TestFixture]
public class HeroTests
{
    [Test]
    public void MockngTest()
    {
        Mock<IWeapon> weapon = new Mock<IWeapon>();
        weapon
            .Setup(w => w.Attack(It.IsAny<ITarget>()))
            .Callback(() => weapon.Object.DurabilityPoints -=1);
    }
}

