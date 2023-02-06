using BudgetSite.Enums;

namespace BudgetSite.Interfaces
{
    /// <summary>
    /// Interface to be implemented by clothing budget items
    /// </summary>
    public interface IClothing
    {
        /// <summary>
        /// Retrieves the type of the clothing item
        /// </summary>
        /// <returns>ClothingType</returns>
        ClothingType GetClothingType();
    }
}
