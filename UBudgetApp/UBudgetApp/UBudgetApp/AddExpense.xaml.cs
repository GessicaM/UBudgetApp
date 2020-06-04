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
            Expense expense = ((AddExpenseViewModel)BindingContext).Expense;
           
            if (expense.ExpenseId == 0)
            {
                switch (expense.Category)
                {
                    case "Transport":
                        expense.PictureUrl = "Assets/Icons/autoNTransport.png";
                        break;
                    case "Education":
                        expense.PictureUrl = "Assets/Icons/education.png";
                        break;
                    case "Entertainment":
                        expense.PictureUrl = "Assets/Icons/entertainment.png";
                        break;
                    case "Eating Out":
                        expense.PictureUrl = "Assets/Icons/foodNDining.png";

                        break;
                    case "Gifts":
                        expense.PictureUrl = "Assets/Icons/gifts.png";

                        break;
                    case "Health":
                        expense.PictureUrl = "Assets/Icons/healthNFitness.png";
                        break;
                    case "Kids":
                        expense.PictureUrl = "Assets/Icons/kids.png";
                        break;
                    case "Miscellaneous":
                        expense.PictureUrl = "Assets/Icons/miscellaneous.png";
                        break;
                    case "Personal Care":
                        expense.PictureUrl = "Assets/Icons/personalCare.png";
                        break;
                    case "Shopping":
                        expense.PictureUrl = "Assets/Icons/shopping.png";
                        break;
                    case "Travel":
                        expense.PictureUrl = "Assets/Icons/travel.png";
                        break;
                    case "Utilities":
                        expense.PictureUrl = "Assets/Icons/utilities.png";

                        break;

                }
            }

            MessagingCenter.Send(this, "AddExpense", expense);

            Navigation.PopModalAsync();



        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
           
            //To go back to ExpenseListpage
            Navigation.PopModalAsync();

        }
        private void SelectedDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
           var NewDate = e.NewDate.ToShortDateString();


        }
    }
}
