using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp_ARO.Models
{

    public class ContactList
    {
        public string Next { get; set; }
        public string Count { get; set; }
        public string Previous { get; set; }
        public List<Contact> Results { get; set;}
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Skin_color { get; set; }
        public string Eye_color { get; set; }
        public string Birth_year { get; set; }
        public string Gender { get; set; }
        public string[] Films { get; set; }
        public string[] Species { get; set; }
        public string[] Vehicles { get; set; }
        public string[] Starships { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Url { get; set; }

        // merging all details to be shown in description
        public string contactDetail
       {
            get
            {
                string na = "n/a";
                StringBuilder sb = new StringBuilder();
                
                if (!string.IsNullOrWhiteSpace(Gender) && Gender != na)
                {
                    sb.Append(string.Format("Is a {0} ", Gender));
                }
                if (!string.IsNullOrWhiteSpace(Birth_year) && Birth_year != na)
                {
                    sb.Append(string.Format("born in {0} ", Birth_year));
                }
                if (!string.IsNullOrWhiteSpace(Gender) && Hair_color != na)
                {
                    sb.Append(string.Format("having {0} hair ", Hair_color));
                }
                if (!string.IsNullOrWhiteSpace(Gender) && Hair_color != na)
                {
                    sb.Append(string.Format("and is {0} tall", Height));
                }

                sb.Append(".");
                string detail = sb.ToString();
                //capitalizing first latter of the string
                if (detail.Length > 0)
                {
                    detail = char.ToUpper(detail[0]) + detail.Substring(1);
                }

                return detail;
            }
         }

        /*public Contact(string _name, string _height, string _eyeColor, string _birthYear)
        {
            Name = _name;
            Height = _height;
            Eye_color = _eyeColor;
            Birth_year = _birthYear;

            //add other fields as required
            // ...
        }*/
    }
}
