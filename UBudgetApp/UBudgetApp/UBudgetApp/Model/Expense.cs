using System;
using System.Collections.Generic;
using System.Text;

namespace UBudgetApp.Model
{
    public enum ExpenseCategory
    {
        Entertainment,
        Education,
        Shopping,
        PersonalCare,
        HealthNFitness,
        Kids,
        FoodNDining,
        Gifts,
        Utilities,
        AutoNTransport,
        Travel,
        Miscellaneous
    }
    public class Expense
    {
        public string Name { get; set; }
        public string Filename { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public ExpenseCategory Category { get; set; }



        //Constructor
        public Expense(string name, double amount, DateTime date, ExpenseCategory category)
        {
            Name = name;
            Amount = amount;
            Date = date;
            Category = category;


        }
        public Expense()
        {

        }

    }

   
}
