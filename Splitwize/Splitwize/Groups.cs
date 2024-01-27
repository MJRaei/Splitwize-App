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
        public bool ExpenseSimplifier { get; set; } = false;
        public Dictionary<Members, double> MemberBalance { get; set; } = new Dictionary<Members, double>();

        public Groups(string groupName) 
        {
            this.GroupName = groupName;
            foreach (var member in GroupMembers)
            {
                MemberBalance.Add(member, 0);
            }
        }
        public Groups() { }

        public ExpenseCalculator CreateExpense()
        {
            var newExpense = new ExpenseCalculator();
            Expense.Add(newExpense);
            return newExpense;
        }

        public void Execute()
        {
            foreach (ExpenseCalculator expense in Expense)
            {
                expense.Execute();
            }
            if (ExpenseSimplifier)
            {
                

            }
        }
    }
}
