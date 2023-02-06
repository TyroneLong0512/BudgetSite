namespace BudgetSite.Interfaces
{
    /// <summary>
    /// Core interface to be implemented by the budget item base classes
    /// </summary>
    public interface IBudgetItem
    {
        /// <summary>
        /// Returns the total of the item
        /// </summary>
        /// <returns>decimal</returns>
        decimal GetItemTotal();

        /// <summary>
        /// Returns the item name
        /// </summary>
        /// <returns>string</returns>
        string GetItemName();

        /// <summary>
        /// Returns the type of the item
        /// </summary>
        /// <returns>Type</returns>
        Type GetItemType();

        /// <summary>
        /// Returns the store the item was bought from
        /// </summary>
        /// <returns>string</returns>
        string GetStoreBoughtFrom();
    }
}
