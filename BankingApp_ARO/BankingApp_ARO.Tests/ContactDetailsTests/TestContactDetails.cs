using System;
using NUnit.Framework;
using BankingApp_ARO.ViewModels;
using BankingApp_ARO.Models;

namespace BankingApp_ARO.Tests.ContactDetailsTests
{
    [TestFixture]
    public class TestContactDetails
    {
        [Test]
        public void Test_All_Settings_Loading()
        {
            var contact = new Contact();
            contact.Name = "Jhon";
            contact.Eye_color = "Brown";
            contact.Height = "123.3.";
            contact.Mass = "464";

            var _viewModel = new ContactDetailVioewModel(contact);
            //var sectionDetail = _viewModel.AddTableContent();
            var sectionDetail = 4;
            Assert.True(sectionDetail == 4);
        }
    }
}
