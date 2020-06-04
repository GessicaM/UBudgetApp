using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBudgetApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UBudgetApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpenseListPage : ContentPage
    {
        public ExpenseListPage()
        {
            InitializeComponent();
        }

        private void AddExpenseButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddExpense());
        }
        private void RemoveTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;


            Expense expense = ((ExpenseListViewModel)BindingContext).
                Expenses.Where(exp => exp.ExpenseId == (int)tappedEventArgs.Parameter).FirstOrDefault();
            ((ExpenseListViewModel)BindingContext).Expenses.Remove(expense);
        }
    }
}