using BudgetSite.Enums;

namespace BudgetSite.Interfaces
{
    /// <summary>
    /// Interface to be implemented by gift budget items
    /// </summary>
    public interface IGift
    {
        /// <summary>
        /// Returns the type of gift of the item
        /// </summary>
        /// <returns>GiftType</returns>
        GiftType GetGiftType();
    }
}
