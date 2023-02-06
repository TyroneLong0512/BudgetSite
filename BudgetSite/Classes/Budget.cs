using BudgetSite.Base_Classes;
using BudgetSite.Interfaces;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Base implementation of the IBudget interface
    /// </summary>
    public class Budget : ItemGrouping, IBudget, IDisposable
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of Budget with a provided collection of budget items
        /// </summary>
        /// <param name="budgetItems"></param>
        public Budget(IEnumerable<IBudgetItem> budgetItems) : base(budgetItems)
        {
        }

        /// <summary>
        /// Creates a new instance of Budget
        /// </summary>
        public Budget() : base()
        {
            
        }
        #endregion

        #region Public Methods
        public override void LoadAllItems()
        {
            //ToDo: Implement data access layer
            throw new NotImplementedException();
        }

        public override void LoadItemsByType<TItem>()
        {
            //ToDo: Implement data access layer
            throw new NotImplementedException();
        }
        #endregion
    }
}
