using System;
using System.Collections.Generic;
using BankingApp_ARO.Models;
using System.Text.RegularExpressions;
using BankingApp_ARO.ViewModels;

using Xamarin.Forms;

namespace BankingApp_ARO.Views
{
    public partial class ContactDetail : ContentPage
    {
        public ContactDetailVioewModel ContactDetailVM;

        public ContactDetail(Contact _contact)
        {
            if (_contact == null)
            {
                throw new ArgumentNullException();
            }

            ContactDetailVM = new ContactDetailVioewModel(_contact);

            InitializeComponent();
            SetUpView();
        }

        void SetUpView()
        {
            if (string.IsNullOrEmpty(ContactDetailVM.contact.Name))
            {
                Title = "Add Detail";
            }
            else
            {
                Title = ContactDetailVM.contact.Name;
            }

            var root = new TableRoot();
            var section1 = ContactDetailVM.AddTableContent();
            root.Add(section1);
            TableView.Root = root;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SSNValidation());
        }
    }
}



