using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using System.Collections.Generic;

namespace BudgetSite.Interfaces
{
    public interface IBudgetViewModel : IViewModel
    {
        IBudget Budget { get; set; }

        IExpenses Expenses { get; set; }
    }
}
