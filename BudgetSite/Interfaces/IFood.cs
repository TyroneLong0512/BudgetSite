using BudgetSite.Enums;

namespace BudgetSite.Interfaces
{
    /// <summary>
    /// Interface to be implemented by food budget items
    /// </summary>
    public interface IFood
    {
        /// <summary>
        /// Returns the type of food of the item
        /// </summary>
        /// <returns>FoodType</returns>
        FoodType GetFoodType();
    }
}
