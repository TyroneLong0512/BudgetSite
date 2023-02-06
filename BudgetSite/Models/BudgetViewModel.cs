using BudgetSite.Interfaces;

namespace BudgetSite.Models
{
    public class BudgetViewModel : IBudgetViewModel
    {
        #region Properties
        public IBudget Budget { get; set; }
        public IExpenses Expenses { get; set; }
        #endregion

        #region Constructor
        public BudgetViewModel(IBudget budget, IExpenses expenses)
        {
            Budget = budget;
            Expenses = expenses;
        }
        #endregion
    }
}
