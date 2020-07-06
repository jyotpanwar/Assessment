using System;
using System.Collections.Generic;
using BankingApp_ARO.ViewModels;

using Xamarin.Forms;

namespace BankingApp_ARO.Views
{
    public partial class SSNValidation : ContentPage
    {
        public SSNValidation()
        {
            InitializeComponent();
        }

        // check for validation of security number
        void Entry_Completed(System.Object sender, System.EventArgs e)
        {
            string ssNumber = TextFiled.Text;
            if (string.IsNullOrEmpty(ssNumber))
            {
                DisplayAlert("Error!", "Please enter South African Social Security Number.", "Ok");
            }
            else
            {
                bool isMatch = SSNValidationVM.ValidateSSN(ssNumber);
                if (isMatch)
                {
                    DisplayAlert("Success", "This is a valid South African Social Security Number.", "Ok");
                }
                else
                {
                    DisplayAlert("Error!", "This is not a valid South African Social Security Number.", "Ok");
                }
            }
        }
    }
}
