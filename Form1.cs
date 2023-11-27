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

            personalContacts = new List<Contact>
            {
            new PersonalContact { FirstName = "Олексій", LastName = "Суркаєв", PhoneNumber = "097665432", Email = "surkaev@example.com", BirthDate = new DateTime(1990, 5, 15), Address = "м. Київ, вул.П'ятигорська, 8" },
            new PersonalContact { FirstName = "Максим", LastName = "Ігнатенко", PhoneNumber = "0967754321", Email = "ihnatenko@example.com", BirthDate = new DateTime(1985, 8, 20), Address = "м. Львів, вул. М.Коперника, 22" },
            new PersonalContact { FirstName = "Максим", LastName = "Лисенко", PhoneNumber = "0556743288", Email = "lysenko.com", BirthDate = new DateTime(1978, 3, 10), Address = "м. Харків, вул. Мар'їнська, 37" }
            };

            businessContacts = new List<Contact>
            {
            new BusinessContact { FirstName = "Влад", LastName = "Ковальчук", PhoneNumber = "0675432887", Email = "kovalchuk@example.com", CompanyName = "ABC Corp", Position = "Менеджер" },
            new BusinessContact { FirstName = "Ольга", LastName = "Мельник", PhoneNumber = "0976548609", Email = "melnuk@example.com", CompanyName = "XYZ Ltd", Position = "Директор" },
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

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            using (AddPersonalContactForm addForm = new AddPersonalContactForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Отримання даних з форми
                    PersonalContact newPersonalContact = new PersonalContact
                    {
                        FirstName = addForm.FirstName,
                        LastName = addForm.LastName,
                        PhoneNumber = addForm.PhoneNumber,
                        Email = addForm.Email,
                        BirthDate = addForm.BirthDate,
                        Address = addForm.Address
                    };

                    // Додавання нового контакту до списку
                    personalContacts.Add(newPersonalContact);

                    // Оновлення таблиці
                    PopulateContactList(listViewPersonalContacts, personalContacts);
                }
            }
        }

        private void btnAddBusinessContact_Click(object sender, EventArgs e)
        {
            using (AddBusinessContactForm addForm = new AddBusinessContactForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Отримання даних з форми
                    BusinessContact newBusinessContact = new BusinessContact
                    {
                        FirstName = addForm.FirstName,
                        LastName = addForm.LastName,
                        PhoneNumber = addForm.PhoneNumber,
                        Email = addForm.Email,
                        CompanyName = addForm.Company,
                        Position = addForm.Position
                    };

                    // Додавання нового бізнес-контакту до списку
                    businessContacts.Add(newBusinessContact);

                    // Оновлення таблиці бізнес-контактів
                    PopulateContactList(listViewBusinessContacts, businessContacts);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (DeleteContactForm deleteForm = new DeleteContactForm())
            {
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    // Отримання номеру телефону для видалення
                    string phoneNumberToDelete = deleteForm.PhoneNumber;

                    // Пошук контакту за номером телефону і видалення його зі списку
                    Contact contactToRemove = personalContacts.Find(c => c.PhoneNumber == phoneNumberToDelete);
                    if (contactToRemove != null)
                    {
                        personalContacts.Remove(contactToRemove);
                        PopulateContactList(listViewPersonalContacts, personalContacts);
                    }
                    else
                    {
                        MessageBox.Show("Контакт не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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