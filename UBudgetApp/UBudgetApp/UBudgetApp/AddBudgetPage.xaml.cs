using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBudgetApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UBudgetApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBudgetPage : ContentPage
    {
        public AddBudgetPage()
        {
            InitializeComponent();

            
        }

       
        private async void BtnAddBudget_Clicked(object sender, EventArgs e)
        {
            var budget = (Budget)BindingContext;
            if(string.IsNullOrWhiteSpace(budget.Filename))
            {
                //create and save
                var filename = Path.Combine(

                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),

                    $"{Path.GetRandomFileName()}.budgets.txt");

                File.WriteAllText(filename, SetBudget.Text);

            }

            else

            {

                //Update

                File.WriteAllText(budget.Filename, SetBudget.Text);

            }



            await Navigation.PopModalAsync();
        }

        

        private async void BtnDeleteBudget_Clicked(object sender, EventArgs e)
        {
            var budget = (Budget)BindingContext;

            if (File.Exists(budget.Filename))

            {
                File.Delete(budget.Filename);
            }

            await Navigation.PopModalAsync();
        }
    }
}