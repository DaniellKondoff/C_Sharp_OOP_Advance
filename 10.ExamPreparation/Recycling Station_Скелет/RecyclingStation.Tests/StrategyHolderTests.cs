using NUnit.Framework;
using RecyclingStation.BisinessLayer.Attributes;
using RecyclingStation.BisinessLayer.Strategies;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class StrategyHolderTests
{
    [Test]
    public void TestPropertyForReadOnlyCollection()
    {
        //Arrange
        IGarbageDisposalStrategy ds = new BurnableGarbageDisposalbeStrategy();
        Type disType = typeof(DisposableAttribute);
        Dictionary<Type, IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        IStrategyHolder sut = new StrategyHolder(strategies);

        //Act
        Type type = sut.GetDisposalStrategies.GetType();

        //Assert
        Assert.IsTrue(sut.AddStrategy(disType,ds));
    }

    [Test]
    public void AddingStrategyTest()
    {
        //Arrange
        IGarbageDisposalStrategy ds = new BurnableGarbageDisposalbeStrategy();
        Type disType = typeof(DisposableAttribute);
        Dictionary<Type, IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        IStrategyHolder sut = new StrategyHolder(strategies);

        bool result = sut.AddStrategy(disType, ds);
        bool result1 = sut.AddStrategy(disType, ds);
        bool result2 = sut.AddStrategy(disType, ds);


        //Assert
        Assert.AreEqual(1,sut.GetDisposalStrategies.Count);
    }

    [Test]
    public void AddDifferentStrategyAndCheckCollection()
    {
        //Arrange
        IGarbageDisposalStrategy ds = new BurnableGarbageDisposalbeStrategy();

        Type disType = typeof(RecyclableStrategyAttribute);
        Type disType1 = typeof(BurnableStrategyAttribute);
        Type disType2 = typeof(StorableStrategyAttribute);
        Dictionary<Type, IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        IStrategyHolder sut = new StrategyHolder(strategies);

        bool result = sut.AddStrategy(disType, ds);
        bool result1 = sut.AddStrategy(disType1, ds);
        bool result2 = sut.AddStrategy(disType2, ds);


        //Assert
        Assert.AreEqual(3, sut.GetDisposalStrategies.Count);
    }

    [Test]
    public void RemovingStrategyTest()
    {
        //Arrange
        IGarbageDisposalStrategy ds = new BurnableGarbageDisposalbeStrategy();
        Type disType = typeof(DisposableAttribute);
        Dictionary<Type, IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        IStrategyHolder sut = new StrategyHolder(strategies);

        bool result = sut.AddStrategy(disType, ds);
       
        
        //Assert
        Assert.IsTrue(sut.RemoveStrategy(disType));
    }

    [Test]
    public void RemoveStrategyAndCheckCount()
    {
        //Arrange
        IGarbageDisposalStrategy ds = new BurnableGarbageDisposalbeStrategy();
        Type disType = typeof(RecyclableStrategyAttribute);
        Type disType1 = typeof(BurnableStrategyAttribute);
        Type disType2 = typeof(StorableStrategyAttribute);
        Dictionary<Type, IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
        IStrategyHolder sut = new StrategyHolder(strategies);

        bool result = sut.AddStrategy(disType, ds);
        bool result1 = sut.AddStrategy(disType1, ds);
        bool result2 = sut.AddStrategy(disType2, ds);

        bool removeResult = sut.RemoveStrategy(disType);

        //Assert
        Assert.AreEqual(2,sut.GetDisposalStrategies.Count);
    }
}

