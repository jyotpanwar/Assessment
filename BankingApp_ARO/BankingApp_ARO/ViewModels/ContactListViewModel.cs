using System;
using System.Collections.Generic;
using BankingApp_ARO.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace BankingApp_ARO.ViewModels
{
    public class ContactListViewModel
    {
        public ContactListViewModel()
        {

        }

        public async System.Threading.Tasks.Task<ContactList> GetContacts()
        {
            var _client = new HttpClient();
            string url = App.appurl + "people/";
            var response = await _client.GetAsync(url);
            ContactList list = null; //handle null while calling GetContacts() method

            if (response.IsSuccessStatusCode)
            {
                var responseString = response.Content.ReadAsStringAsync().Result;
                list = JsonConvert.DeserializeObject<ContactList>(responseString);
            }

            return list;
        }
    }
}
