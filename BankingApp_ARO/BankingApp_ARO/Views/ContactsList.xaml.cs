using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BankingApp_ARO.ViewModels;
using BankingApp_ARO.Models;


namespace BankingApp_ARO.Views
{
    public partial class ContactsList : ContentPage
    {
        private ActivityIndicator activitiInd;
        private ContactListViewModel viewModel = new ContactListViewModel();
        ObservableCollection<Contact> list = new ObservableCollection<Contact>();

        public ContactsList()
        {
            InitializeComponent();
            AddActivityIndicator();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (list.Count == 0)
            {
                ContactList contacts = await viewModel.GetContacts();
                List<Contact> _contactList = contacts.Results;
                list = new ObservableCollection<Contact>(_contactList);
                if (list != null) // check to prevent crash if the list is null
                {
                    contantsListView.ItemsSource = list;
                }
                RemoveActivityIndicator();
            }
        }

        public void AddNewContact(object sender, System.EventArgs e)
        {
            //assign empty contact 
            Navigation.PushAsync(new ContactDetail(new Contact()));            
        }

        //when list item is selected
        void ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            
            contantsListView.SelectedItem = null; // to reset the selection
        }

        //called when list item is tapped
        void ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.ItemIndex);
            var contact = list[e.ItemIndex] as Contact;
            Navigation.PushAsync(new ContactDetail(contact));
        }

        void AddActivityIndicator()
        {
            contantsListView.IsVisible = false;
            activitiInd = new ActivityIndicator();
            activitiInd.HorizontalOptions = LayoutOptions.Center;
            activitiInd.VerticalOptions = LayoutOptions.Center;
            activitiInd.IsRunning = true;
            stackLayout.Children.Insert(0, activitiInd);
        }

        void RemoveActivityIndicator()
        {
            if (activitiInd != null)
            {
                stackLayout.Children.Remove(activitiInd);
                contantsListView.IsVisible = true;
                activitiInd = null;
            }
        }
    }
}
