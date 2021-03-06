﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[TestFixture]
public class AxeTests
{
    private const int AxeAttack = 1;
    private const int AxeDurability = 1;
    private const int DummyHealth = 20;
    private const int DummyExp = 20;

    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void TestInit()
    {       
        //Arange
        this.axe = new Axe(AxeAttack, AxeDurability);
        this.dummy = new Dummy(DummyHealth, DummyExp);
    }

    [Test]
    public void AxeLosesDurabilityAferAttack()
    {
        ////Arange
        //Axe axe = new Axe(10,10);
        //Dummy dummy = new Dummy(10, 10);

        //Act
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(0, axe.DurabilityPoints);
    }

    [Test]
    public void AxeAttackWithBrokenAxe()
    {
        ////Arange
        //Axe axe = new Axe(1, 1);
        //Dummy dummy = new Dummy(20, 20);

        //Act
        axe.Attack(dummy);

        //Assert
        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.AreEqual("Axe is broken.", ex.Message);
    }
}

