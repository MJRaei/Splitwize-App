using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwize
{
    public enum SplitMethod
    {
        Equally,
        ExactAmount,
        Percentage,
        Shares,
        Adjustment
    }

    public enum ExpenseCategory
    {
        Entertainment,
        FoodAndDrink,
        Home,
        Life,
        Transportation,
        Uncategorized,
        Utilities
    }
}
