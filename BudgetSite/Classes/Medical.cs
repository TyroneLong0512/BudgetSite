using BudgetSite.Base_Classes;
using BudgetSite.Interfaces;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Class to describe and handle functionality for medical budget items
    /// </summary>
    public class Medical : BudgetItem, IMedical
    {
        #region Constructors
        /// <summary>
        /// Constructs an instance of Medical
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        /// <param name="storeBoughtFrom">The store the item was bought from</param>
        public Medical(string itemName, decimal total, string storeBoughtFrom) : base(itemName, total, storeBoughtFrom)
        {
        }

        /// <summary>
        /// Constructs an instance of Medical with the store bought from set to default
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="total">The total cost of the item</param>
        public Medical(string itemName, decimal total) : base(itemName, total)
        {

        }

        /// <summary>
        /// Constructs an instance of Medical with all values set to default
        /// </summary>
        public Medical() : base()
        {

        }
    }
    #endregion
}
