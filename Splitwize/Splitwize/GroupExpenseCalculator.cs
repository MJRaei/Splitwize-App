using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwize
{
    public class GroupExpenseCalculator : Groups
    {

        public Dictionary<List<Members>, double> OwersExpenseSplitor { get; set; } = new Dictionary<List<Members>, double>();


        public void GroupExpenseSimplifier()
        {
            foreach (var member in MemberBalance.Keys)
            {
                foreach (var expense in Expense)
                {
                    foreach (KeyValuePair<List<Members>, double> dic in expense.OwersExpenseSplitor)
                    {
                        if (member.FirstName == dic.Key[0].FirstName)
                        {
                            MemberBalance[member] -= dic.Value;
                        }
                        if (member.FirstName == dic.Key[1].FirstName)
                        {
                            MemberBalance[member] += dic.Value;
                        }
                    }
                }
            }

        }

        public void Execute()
        {
            GroupExpenseSimplifier();
        }
        
    }
}
