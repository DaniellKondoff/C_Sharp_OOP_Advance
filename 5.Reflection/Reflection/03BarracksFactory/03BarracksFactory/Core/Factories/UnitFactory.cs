namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string unitNameSpace = "_03BarracksFactory.Models.Units.";
        //Problem 3 Factory Pattern
        public IUnit CreateUnit(string unitType)
        {
            Type typeUnit = Type.GetType(unitNameSpace + unitType);
            IUnit unitInstance = (IUnit)Activator.CreateInstance(typeUnit);
            return unitInstance;
        }
    }
}
