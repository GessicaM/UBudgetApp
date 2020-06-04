using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBudgetApp.Model;
using Xamarin.Forms;

namespace UBudgetApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var budgets = new List<Budget>();

            var files = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),

                "*.budgets.txt");

            foreach (var filename in files)

            {
                var budget = new Budget
                {
                    Text = File.ReadAllText(filename),

                    Filename = filename,

                };

                budgets.Add(budget);

            }

            listView.ItemsSource = budgets;
        }

        
        private async void BtnAddBudget_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddBudgetPage
            { 
                BindingContext = new Budget()
            });
        }

        private void BtnAddExp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ExpenseListPage());
        }

        private  void BtnExpList_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)

        {

            if (e.SelectedItem != null)

            {

                await Navigation.PushModalAsync(new AddBudgetPage

                {

                    BindingContext = (Budget)e.SelectedItem

                });

            }

        }
    }
}
