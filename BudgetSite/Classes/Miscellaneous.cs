using BudgetSite.Base_Classes;
using BudgetSite.Interfaces;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Class to describe and handle functionality for miscellaneous budget items
    /// </summary>
    public class Miscellaneous : BudgetItem, IMiscellaneous
    {
        #region Constructors
        /// <summary>
        /// Constructs an instance of Miscellaneous
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Miscellaneous(string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
        }

        /// <summary>
        /// Constructs an instance of Miscellaneous with the store bought from set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        public Miscellaneous(string itemName, decimal total) : base(itemName, total)
        {

        }

        /// <summary>
        /// Constructs an instance of Miscellaneous with all values set to default
        /// </summary>
        public Miscellaneous() : base()
        {

        }
    }
    #endregion
}
