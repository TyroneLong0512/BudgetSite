using BudgetSite.Base_Classes;
using BudgetSite.Interfaces;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Class to describe and handle functionality for housing budget items
    /// </summary>
    public class Insurance : BudgetItem, IInsurance
    {
        #region Constructors
        /// <summary>
        /// Constructs an instance of Insurance
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Insurance(string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
        }

        /// <summary>
        /// Constructs an instance of Insurance with the store bought from set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        public Insurance(string itemName, decimal total) : base(itemName, total)
        {

        }

        /// <summary>
        /// Constructs an instance of Insurance with all values set to default
        /// </summary>
        public Insurance() : base()
        {

        }
        #endregion
    }
}
