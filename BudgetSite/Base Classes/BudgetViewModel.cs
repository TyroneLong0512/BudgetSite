using BudgetSite.Interfaces;

namespace BudgetSite.Base_Classes
{
    public class BudgetViewModel : IBudgetViewModel
    {
        public IBudget Budget { get; set ; }
        public IExpenses Expenses { get; set; }

        public BudgetViewModel(IBudget budget, IExpenses expenses)
        {
            Budget = budget;
            Expenses = expenses;
        }
    }
}
