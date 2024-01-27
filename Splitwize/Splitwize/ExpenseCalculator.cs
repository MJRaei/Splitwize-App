using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Splitwize
{
    public class ExpenseCalculator : GroupExpenseCalculator
    {
        public SplitMethod SplitedMethod { get; set; }
        public double TotalAmount { get; set; }
        public string ExpenseName { get; set; }
        public ExpenseCategory Category { get; set; }
        public Members Payer { get; set; }
        public List<Members> Owers { get; set; } = new List<Members>();
        public DateTime ExpenseDate { get; set; } = DateTime.Now;

        public ExpenseCalculator(string expenseName, SplitMethod splitMethod, double totalAmount, ExpenseCategory category,
            Members payer, List<Members> owers)
        {
            ExpenseName = expenseName;
            SplitedMethod = splitMethod;
            TotalAmount = totalAmount;
            Category = category;
            Payer = payer;
            Owers = owers;
        }
        public ExpenseCalculator() { }

        public void Splitor()
        {
            double payerCredit = TotalAmount;

            switch (SplitedMethod)
            {
                case SplitMethod.Equally:
                    double owedMoney = TotalAmount / Owers.Count;

                    foreach (var member in Owers)
                    {
                        List<Members> payerAndOwer = new List<Members>() { Payer };
                        if (member != Payer)
                        {
                            payerAndOwer.Add(member);
                            OwersExpenseSplitor.Add(payerAndOwer, -owedMoney);
                        }
                    }

                    break;
            }
        }

        public void Execute()
        {
            Splitor();
        }



    }
}
