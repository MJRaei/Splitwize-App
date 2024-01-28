using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwize
{
    public class Groups
    {
        public List<Members> GroupMembers { get; set; } = new List<Members>();
        public string GroupName { get; set; }
        public List<ExpenseCalculator> Expense {  get; set; } = new List<ExpenseCalculator>();
        public Dictionary<List<Members>, double> OwersExpenseSplitor { get; set; } = new Dictionary<List<Members>, double>();
        public bool ExpenseSimplifier { get; set; } = false;
        public Dictionary<Members, double> MemberBalance { get; set; } = new Dictionary<Members, double>();

        public Groups(string groupName) 
        {
            this.GroupName = groupName;


        }
        public Groups() { }

        public ExpenseCalculator CreateExpense()
        {
            var newExpense = new ExpenseCalculator();
            Expense.Add(newExpense);
            return newExpense;
        }

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
            foreach (ExpenseCalculator expense in Expense)
            {
                expense.Execute();
            }
            if (ExpenseSimplifier)
            {
                foreach (var members in GroupMembers)
                {
                    MemberBalance.Add(members, 0);
                }
                GroupExpenseSimplifier();

            }
        }
    }
}
