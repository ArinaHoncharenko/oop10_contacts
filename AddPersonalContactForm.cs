using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop10_contacts
{
    public partial class AddPersonalContactForm : Form
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Address { get; private set; }

        public AddPersonalContactForm()
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

            // Перевірка електронної пошти
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
            BirthDate = dtpBirthDate.Value;
            Address = txtAddress.Text;

            // Закриття форми
            DialogResult = DialogResult.OK;
            Close();
        }

        // Метод для перевірки дійсності електронної пошти
        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        // Метод для перевірки дійсності номеру телефону
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Перевірка, що номер містить лише цифри і складається з 10 символів
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        // Метод для перевірки, чи всі поля заповнені
        private bool AreAllFieldsFilled()
        {
            // Перевірка всіх TextBox і DateTimePicker на заповненість
            return !string.IsNullOrWhiteSpace(txtFirstName.Text)
                && !string.IsNullOrWhiteSpace(txtLastName.Text)
                && !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtAddress.Text);
        }
    }
}
