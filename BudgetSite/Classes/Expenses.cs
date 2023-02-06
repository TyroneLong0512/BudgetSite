using BudgetSite.Base_Classes;
using BudgetSite.Interfaces;

namespace BudgetSite.Classes
{
    /// <summary>
    /// Implementation of the IExpenses interface to handle functionality of expenses
    /// </summary>
    public class Expenses : ItemGrouping, IExpenses
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of Expenses with a provided collection of budget items
        /// </summary>
        /// <param name="budgetItems">A collection of items to create the expenses with</param>
        public Expenses(IEnumerable<IBudgetItem> budgetItems) : base(budgetItems)
        {

        }

        /// <summary>
        /// Creates a new instance of Expenses
        /// </summary>
        public Expenses() : base()
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
            //ToDo: Implment data access layer
            throw new NotImplementedException();
        }
        #endregion


    }
}
