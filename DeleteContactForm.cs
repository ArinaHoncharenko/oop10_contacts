using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop10_contacts
{
    public partial class DeleteContactForm : Form
    {
        public string PhoneNumber { get; private set; }
        public DeleteContactForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Перевірка номеру телефону
            if (!IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Введіть дійсний номер телефону (10 цифр).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Отримання номеру телефону для видалення
            PhoneNumber = txtPhoneNumber.Text;

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
    }
}
