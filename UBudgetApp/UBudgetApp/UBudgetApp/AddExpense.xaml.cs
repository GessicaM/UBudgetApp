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
    public partial class AddExpense : ContentPage
    {
        public AddExpense()
        {
            InitializeComponent();
        }
        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //To get the Expense
            Expense expense = ((AddExpenseViewModel)BindingContext).Expense;

           //To pass it to ExpenseListPage
           MessagingCenter.Send(this, "AddExpense", expense);
            
            //To go back to ExpenseListpage 
            Navigation.PopModalAsync();


        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
           
            //To go back to ExpenseListpage
            Navigation.PopModalAsync();

        }
    }
}