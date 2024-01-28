using Splitwize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwizeConsoleApp
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Groups group1 = new Groups("groupOne");

            Members javad = new Members() { FirstName = "Javad", LastName = "Raei", PhoneNumber = "1234567890" };
            Members azin = new Members() { FirstName = "Azin", LastName = "Dinarvand", PhoneNumber = "1234567891" };
            Members mehran = new Members() { FirstName = "Mehran", LastName = "Abbaszadeh", PhoneNumber = "1234567892" };

            group1.GroupMembers.Add(javad);
            group1.GroupMembers.Add(azin);
            group1.GroupMembers.Add(mehran);

            var expense2 = group1.CreateExpense();

            List<Members> owers = new List<Members> { javad, azin, mehran };
            expense2.ExpenseName = "Rent";
            expense2.SplitedMethod = SplitMethod.Equally;
            expense2.TotalAmount = 1500;
            expense2.Category = ExpenseCategory.Utilities;
            expense2.Payer = javad;
            expense2.Owers = owers;

            //expense2.Execute();

            var expense3 = group1.CreateExpense();

            expense3.ExpenseName = "Rent";
            expense3.SplitedMethod = SplitMethod.Equally;
            expense3.TotalAmount = 2100;
            expense3.Category = ExpenseCategory.Utilities;
            expense3.Payer = azin;
            expense3.Owers = owers;

            //expense3.Execute();

            group1.Execute();
            //group1.Execute();

            foreach (ExpenseCalculator expense in group1.Expense)
            {
                foreach (KeyValuePair<List<Members>, double> dic in expense.OwersExpenseSplitor)
                {
                    Console.WriteLine(dic.Key[1].FirstName + dic.Value.ToString());
                }
            }


            /*            foreach (KeyValuePair<List<Members>, double> dic in  expense2.OwersExpenseSplitor)
                        {
                            //Console.WriteLine(dic.Key[1].FirstName);
                            foreach (var item in dic.Key)
                            {
                                Console.WriteLine(item);
                            }
                        }*/

            //group1.ExpenseSimplifier = true;
            //group1.Execute();

            foreach (var dic in group1.MemberBalance)
            {
                Console.WriteLine(dic.Key.FirstName + dic.Value.ToString());
            }

/*            foreach (var members in group1.GroupMembers)
            {
                Console.WriteLine("First Name: {0}, Last Name: {1}, Phone Number: {2}", members.FirstName, members.LastName, members.PhoneNumber);
            }*/
        }
    }
}
