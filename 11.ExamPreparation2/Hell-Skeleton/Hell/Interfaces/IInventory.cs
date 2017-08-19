using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IInventory
{
    long TotalAgilityBonus { get; }
    long TotalDamageBonus { get; }
    long TotalHitPointsBonus { get; }
    long TotalIntelligenceBonus { get; }
    long TotalStrengthBonus { get; }

    void AddRecipeItem(IRecipe recipe);
    void AddCommonItem(IItem item);
}

