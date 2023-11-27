using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace oop10_contacts
{
    public partial class Form1 : Form
    {
        private List<Contact> personalContacts;
        private List<Contact> businessContacts;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізація списків контактів (додайте власні дані)
            personalContacts = new List<Contact>
        {
            new PersonalContact { FirstName = "John", LastName = "Doe", PhoneNumber = "123-456-7890", Email = "john.doe@example.com", BirthDate = new DateTime(1990, 5, 15), Address = "123 Main St, City" }
        };

            businessContacts = new List<Contact>
        {
            new BusinessContact { FirstName = "Jane", LastName = "Smith", PhoneNumber = "987-654-3210", Email = "jane.smith@example.com", CompanyName = "ABC Corp", Position = "Manager" }
        };

            // Заповнення списків контактів при запуску додатку
            PopulateContactList(listViewPersonalContacts, personalContacts);
            PopulateContactList(listViewBusinessContacts, businessContacts);
        }

        private void PopulateContactList(ListView listView, List<Contact> contacts)
        {
            // Очищення вмісту списку перед оновленням
            listView.Items.Clear();

            // Додавання кожного контакту до списку
            foreach (var contact in contacts)
            {
                ListViewItem item = new ListViewItem(new[] { contact.FirstName, contact.LastName, contact.PhoneNumber, contact.Email });

                // Перевірка, чи контакт є особистим або бізнесовим і додавання відповідних додаткових даних
                if (contact is PersonalContact)
                {
                    var personalContact = (PersonalContact)contact;
                    item.SubItems.Add(personalContact.BirthDate.ToShortDateString());
                    item.SubItems.Add(personalContact.Address);
                }
                else if (contact is BusinessContact)
                {
                    var businessContact = (BusinessContact)contact;
                    item.SubItems.Add(businessContact.CompanyName);
                    item.SubItems.Add(businessContact.Position);
                }

                listView.Items.Add(item);
            }
        }

    }

    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class PersonalContact : Contact
    {
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
    }

    public class BusinessContact : Contact
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
    }
}
