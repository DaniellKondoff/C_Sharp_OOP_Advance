using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


[TestFixture]
public class HeroInventoryClass
{
    private HeroInventory sut;
    [SetUp]
    public void TestInit()
    {
        this.sut = new HeroInventory();
    }

    [Test]
    public void NullCommonItemThrowsNullException()
    {
        CommonItem item = null;

        //Assert
        Assert.Throws<NullReferenceException>(() => sut.AddCommonItem(item));
    }

    [Test]
    public void NullRecipeThrowsNullException()
    {
        IRecipe recipe = null;

        //Assert
        Assert.Throws<NullReferenceException>(() => sut.AddRecipeItem(recipe));
    }

    [Test]
    public void StrengthBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(1, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AgilityBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(2, this.sut.TotalAgilityBonus);
    }

    [Test]
    public void InteligenceBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(3, this.sut.TotalIntelligenceBonus);
    }

    [Test]
    public void HitPointsBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(4, this.sut.TotalHitPointsBonus);
    }

    [Test]
    public void DamageBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        //Assert
        Assert.AreEqual(5, this.sut.TotalDamageBonus);
    }

    [Test]
    public void AddCommonItem()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);
        Type clazz = typeof(HeroInventory);
        var filed = clazz.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(f => f.GetCustomAttributes(typeof(ItemAttribute)) != null);

        var collection = (Dictionary<string, IItem>)filed.GetValue(this.sut);

        //Assert
        Assert.AreEqual(1, collection.Count);
    }

    [Test]
    public void AddRecipeItem()
    {
        RecipeItem item = new RecipeItem("item", 1, 2, 3, 4, 5,new List<string>());

        this.sut.AddRecipeItem(item);
        Type clazz = typeof(HeroInventory);
        var field = clazz.GetField("recipeItems",BindingFlags.Instance | BindingFlags.NonPublic);

        var collection = (Dictionary<string, IRecipe>)field.GetValue(this.sut);
        //Assert
        Assert.AreEqual(1,collection.Count);
    }

    [Test]
    public void TotalStatsBonus()
    {
        var item1 = new CommonItem("Sword", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item1);

        long totalStatsBonus = sut.TotalAgilityBonus +
                               sut.TotalDamageBonus +
                               sut.TotalHitPointsBonus +
                               sut.TotalIntelligenceBonus +
                               sut.TotalStrengthBonus;

        Assert.AreEqual(15, totalStatsBonus);
    }

    [Test]
    public void DuplicatingCommonItemThrowsException()
    {
        IItem item = new CommonItem("BootsOfTravell", 100, 100, 100, 100, 100);

        this.sut.AddCommonItem(item);

        Assert.Throws<ArgumentException>(() => this.sut.AddCommonItem(item));
    }

    [Test]
    public void DuplicatingRecipeThrowsException()
    {
        List<string> recipeComponents1 = new List<string> { "BootsOfSpeed" };
        IRecipe recipe1 = new RecipeItem("BootsOfTravell", 100, 100, 100, 100, 100, recipeComponents1);

        this.sut.AddRecipeItem(recipe1);

        Assert.Throws<ArgumentException>(() => this.sut.AddRecipeItem(recipe1));
    }

    [Test]
    public void ChainingRecipes()
    {
        List<string> recipeComponents1 = new List<string> { "BootsOfSpeed" };
        IRecipe recipe1 = new RecipeItem("BootsOfTravell", 100, 100, 100, 100, 100, recipeComponents1);
        IItem boots = new CommonItem("BootsOfSpeed", 10, 10, 10, 10, 10);

        List<string> recipeComponents2 = new List<string> { "BootsOfTravell" };
        IRecipe recipe2 = new RecipeItem("BootsOfTravell2", 200, 200, 200, 200, 200, recipeComponents2);

        this.sut.AddCommonItem(boots);
        this.sut.AddRecipeItem(recipe1);
        this.sut.AddRecipeItem(recipe2);
        long totalStatsBonus = this.sut.TotalAgilityBonus
                               + this.sut.TotalStrengthBonus
                               + this.sut.TotalIntelligenceBonus
                               + this.sut.TotalHitPointsBonus
                               + this.sut.TotalDamageBonus;

        Assert.AreEqual(1000, totalStatsBonus);
    }

    [Test]
    public void AddingCommonItemsChangesTotalDamage()
    {
        IItem item1 = new CommonItem("Axe", 11, 12, 13, 14, 15);
        IItem item2 = new CommonItem("Fork", 31, 32, 33, 34, 35);

        this.sut.AddCommonItem(item1);
        this.sut.AddCommonItem(item2);

        Assert.AreEqual(50, this.sut.TotalDamageBonus);
    }

    [Test]
    public void CompleteRecipeForNewItem()
    {
        IItem relic = new CommonItem("SacredRelic", 0, 0, 0, 0, 60);
        List<string> recipeComponents = new List<string> { "SacredRelic", "RadianceRecipe" };
        IRecipe recipe = new RecipeItem("Radiance", 0, 0, 0, 0, 80, recipeComponents);
        IItem radianceRecipe = new CommonItem("RadianceRecipe", 0, 0, 0, 0, 0);

        this.sut.AddCommonItem(relic);
        this.sut.AddRecipeItem(recipe);
        this.sut.AddCommonItem(radianceRecipe);

        Assert.AreEqual(80, this.sut.TotalDamageBonus);
    }

}

