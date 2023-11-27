using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace oop10_contacts
{
    public partial class AddBusinessContactForm : Form
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Company { get; private set; }
        public string Position { get; private set; }

        public AddBusinessContactForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Перевірка, чи всі поля заповнені
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Введіть дійсну електронну пошту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка номеру телефону
            if (!IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Введіть дійсний номер телефону.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Отримання значень з полів форми
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            PhoneNumber = txtPhoneNumber.Text;
            Email = txtEmail.Text;
            Company = txtCompany.Text;
            Position = txtPosition.Text;

            // Закриття форми
            DialogResult = DialogResult.OK;
            Close();
        }

        // Метод для перевірки дійсності номеру телефону
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Перевірка, що номер містить лише цифри і складається з 10 символів
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }
        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        // Метод для перевірки, чи всі поля заповнені
        private bool AreAllFieldsFilled()
        {
            // Перевірка всіх TextBox і DateTimePicker на заповненість
            return !string.IsNullOrWhiteSpace(txtFirstName.Text)
                && !string.IsNullOrWhiteSpace(txtLastName.Text)
                && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtPosition.Text)
                && !string.IsNullOrWhiteSpace(txtCompany.Text);
        }
    }
}
