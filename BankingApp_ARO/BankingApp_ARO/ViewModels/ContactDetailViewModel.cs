using System;
using Xamarin.Forms;
using BankingApp_ARO.Models;
using BankingApp_ARO.Views;

namespace BankingApp_ARO.ViewModels
{
    public class ContactDetailVioewModel
    {
        public Contact contact;

        public ContactDetailVioewModel(Contact _contact)
        {
            contact = _contact;
        }

        public TableSection AddTableContent()
        {
            var nameCell = new CustomEntryCell { EntryText = contact.Name, Placeholder = "Enter Name", LabelText = "Name" };
            var heightCell = new CustomEntryCell { EntryText = contact.Height, Placeholder = "Enter Height", LabelText = "Height" };
            var brthYearCell = new CustomEntryCell { EntryText = contact.Birth_year, Placeholder = "Enter Birth Year", LabelText = "Birth Year" };
            var eyeColorCell = new CustomEntryCell { EntryText = contact.Eye_color, Placeholder = "Enter Eye Color", LabelText = "Eye Color" };
            var section1 = new TableSection();
            section1.Add(nameCell);
            section1.Add(heightCell);
            section1.Add(brthYearCell);
            section1.Add(eyeColorCell);
            return section1;
        }
    }
}
