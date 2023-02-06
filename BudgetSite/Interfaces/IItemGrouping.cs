namespace BudgetSite.Interfaces
{
    /// <summary>
    /// Interface to be implemented by item classes
    /// </summary>
    public interface IItemGrouping
    {
        /// <summary>
        /// Returns all items
        /// </summary>
        /// <returns>IEnumerable of IBudgetItem</returns>
        IEnumerable<IBudgetItem> GetItems();

        /// <summary>
        /// Returns all items of a given type
        /// </summary>
        /// <typeparam name="TItem">The type of the item</typeparam>
        /// <returns>IEnumerable of IBudgetItem</returns>
        IEnumerable<IBudgetItem> GetItemsByType<TItem>() where TItem : IBudgetItem;

        /// <summary>
        /// Returns the item with the highest total cost
        /// </summary>
        /// <returns>IEnumerable of IBudgetItem</returns>
        IEnumerable<IBudgetItem> GetHighestTotalItem();

        /// <summary>
        /// Returns the item with the lowest total cost
        /// </summary>
        /// <returns>IEnumerable of IBudgetItem</returns>
        IEnumerable<IBudgetItem> GetLowestTotalItem();

        /// <summary>
        /// Calculates the total and returns it
        /// </summary>
        /// <returns>decimal</returns>
        decimal GetTotal();

        /// <summary>
        /// Loads all the items for the database
        /// </summary>
        void LoadAllItems();

        /// <summary>
        /// Loads all items of a given type
        /// </summary>
        /// <typeparam name="TItem">The type for the method to load</typeparam>
        void LoadItemsByType<TItem>() where TItem : IBudgetItem;
    }
}
