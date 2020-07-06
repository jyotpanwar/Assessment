using NUnit.Framework;
using BankingApp_ARO.ViewModels;
using BankingApp_ARO.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace BankingApp_ARO.Tests.ContactListTests
{
    public class TestContactList
    {
        public TestContactList()
        {
        }

        [Test]
        public async System.Threading.Tasks.Task Test_If_ContactList_Is_Being_Fetched()
        {

            //fetch test list 
            var viewModel = new ContactListViewModel();
            ContactList contacts = await viewModel.GetContacts();
            var _contactList = contacts.Results;
            Assert.Null(_contactList);
        }
    }
}
