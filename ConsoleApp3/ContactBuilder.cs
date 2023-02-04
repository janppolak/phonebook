using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ContactBuilder
    {
        public List<Contact> AddContacts()
        {
            string userChoice;
            var contacts = new List<Contact>();
            long contactNumber = 0;
            bool isCorrect = true;

            do
            {
                Console.Write("Type in contact name: ");
                var contactName = Console.ReadLine();

                Console.Write("Type in contact number: ");


                do
                {
                    if (isCorrect != long.TryParse(Console.ReadLine(), out contactNumber))
                    {
                        Console.Write("Phone number has to be an integer. Try again: ");
                    }
                    else if (contactNumber.ToString().Count() != 9)
                    {
                        Console.Write("The number should contain 9 digits. Try again: ");
                    }
                }while(isCorrect && contactNumber.ToString().Count() != 9);

                

                var contact = new Contact() { ContactName = contactName, ContactNumber = contactNumber };
                contacts.Add(contact);

                Console.Write("Do you want to add another contact? Type 'y' or 'n': ");
                userChoice = Console.ReadLine();

            } while (userChoice == "y");

            return contacts;
        }

        public static void ShowContacts(List<Contact> contacts)
        {
            var sortedContants = contacts.OrderBy(x => x.ContactName).ToList();
            foreach (Contact contact in sortedContants)
            {
                Console.WriteLine($"Name: {contact.ContactName}, number: {contact.ContactNumber}");
            }
        }

        public static void FindContact(List<Contact> contacts)
        {
            string userChoice;

            Console.Write("Do you want to find a contact? Type 'y' or 'n'?: ");
            userChoice = Console.ReadLine();
            if (userChoice == "y")
            {
                Console.Write("Type in contact name: ");
                var userInput = Console.ReadLine();

                var selectedItem = contacts.Where(x => x.ContactName == userInput);

                foreach (var item in selectedItem)
                {
                    Console.WriteLine($"Name: {item.ContactName}, number: {item.ContactNumber}");
                }
                
            }
        }
    }
}
