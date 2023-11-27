using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace oop10_contacts
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts;
        public Form1()
        {
            InitializeComponent();

            LoadContacts();

            // Заповнення списку контактів при запуску додатку
            PopulateContactList();
        }

        private void LoadContacts()
        {
            string filePath = @"C:\Users\1\source\repos\oop10_contacts\oop10_contacts\contacts.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при читанні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Якщо файл не існує, ініціалізуємо пустий список
                contacts = new List<Contact>();
            }
        }

        private void SaveContacts()
        {
            string filePath = @"C:\Users\1\source\repos\oop10_contacts\oop10_contacts\contacts.json";

            try
            {
                string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateContactList()
        {
            // Очищення вмісту списку перед оновленням
            listViewContacts.Items.Clear();

            // Додавання кожного контакту до списку
            foreach (var contact in contacts)
            {
                ListViewItem item = new ListViewItem(new[] { contact.FirstName, contact.LastName, contact.PhoneNumber, contact.Email, GetContactType(contact) });

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

                listViewContacts.Items.Add(item);
            }
        }

        private string GetContactType(Contact contact)
        {
            if (contact is PersonalContact)
            {
                return "Personal";
            }
            else if (contact is BusinessContact)
            {
                return "Business";
            }
            else
            {
                return "Unknown";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveContacts();
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
