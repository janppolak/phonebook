using System;
using System.Net.Http;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactBuilder addNewContact = new ContactBuilder();
            var contacts = addNewContact.AddContacts();
            ContactBuilder.ShowContacts(contacts);
            ContactBuilder.FindContact(contacts);
            
        }
    }
}
