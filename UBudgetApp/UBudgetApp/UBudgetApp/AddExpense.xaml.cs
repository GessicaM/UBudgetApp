using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Navigation.PopModalAsync();


        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
           

            //Navigation.PopModalAsync();

        }
    }
}