namespace oop10_contacts
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPersonalContacts = new System.Windows.Forms.ListView();
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBusinessContacts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPersonalContact = new System.Windows.Forms.Button();
            this.btnAddBusinessContact = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPersonalContacts
            // 
            this.listViewPersonalContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnPhoneNumber,
            this.columnEmail,
            this.columnBirthDate,
            this.columnAddress});
            this.listViewPersonalContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewPersonalContacts.FullRowSelect = true;
            this.listViewPersonalContacts.GridLines = true;
            this.listViewPersonalContacts.HideSelection = false;
            this.listViewPersonalContacts.Location = new System.Drawing.Point(12, 38);
            this.listViewPersonalContacts.Name = "listViewPersonalContacts";
            this.listViewPersonalContacts.Size = new System.Drawing.Size(854, 133);
            this.listViewPersonalContacts.TabIndex = 0;
            this.listViewPersonalContacts.UseCompatibleStateImageBehavior = false;
            this.listViewPersonalContacts.View = System.Windows.Forms.View.Details;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "Ім\'я";
            this.columnFirstName.Width = 100;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Прізвище";
            this.columnLastName.Width = 120;
            // 
            // columnPhoneNumber
            // 
            this.columnPhoneNumber.Text = "Номер";
            this.columnPhoneNumber.Width = 100;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 170;
            // 
            // columnBirthDate
            // 
            this.columnBirthDate.Text = "Дата народження";
            this.columnBirthDate.Width = 140;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Адреса";
            this.columnAddress.Width = 220;
            // 
            // listViewBusinessContacts
            // 
            this.listViewBusinessContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnCompanyName,
            this.columnPosition});
            this.listViewBusinessContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewBusinessContacts.FullRowSelect = true;
            this.listViewBusinessContacts.GridLines = true;
            this.listViewBusinessContacts.HideSelection = false;
            this.listViewBusinessContacts.Location = new System.Drawing.Point(12, 208);
            this.listViewBusinessContacts.Name = "listViewBusinessContacts";
            this.listViewBusinessContacts.Size = new System.Drawing.Size(774, 133);
            this.listViewBusinessContacts.TabIndex = 1;
            this.listViewBusinessContacts.UseCompatibleStateImageBehavior = false;
            this.listViewBusinessContacts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ім\'я";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Прізвище";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Номер";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 170;
            // 
            // columnCompanyName
            // 
            this.columnCompanyName.Text = "Компанія";
            this.columnCompanyName.Width = 140;
            // 
            // columnPosition
            // 
            this.columnPosition.Text = "Посада";
            this.columnPosition.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Особисті контакти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ділові контакти:";
            // 
            // btnAddPersonalContact
            // 
            this.btnAddPersonalContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPersonalContact.Location = new System.Drawing.Point(158, 9);
            this.btnAddPersonalContact.Name = "btnAddPersonalContact";
            this.btnAddPersonalContact.Size = new System.Drawing.Size(122, 23);
            this.btnAddPersonalContact.TabIndex = 4;
            this.btnAddPersonalContact.Text = "Додати контакт";
            this.btnAddPersonalContact.UseVisualStyleBackColor = true;
            this.btnAddPersonalContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnAddBusinessContact
            // 
            this.btnAddBusinessContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBusinessContact.Location = new System.Drawing.Point(158, 179);
            this.btnAddBusinessContact.Name = "btnAddBusinessContact";
            this.btnAddBusinessContact.Size = new System.Drawing.Size(122, 23);
            this.btnAddBusinessContact.TabIndex = 5;
            this.btnAddBusinessContact.Text = "Додати контакт";
            this.btnAddBusinessContact.UseVisualStyleBackColor = true;
            this.btnAddBusinessContact.Click += new System.EventHandler(this.btnAddBusinessContact_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(12, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Видалити контакт";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 386);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddBusinessContact);
            this.Controls.Add(this.btnAddPersonalContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewBusinessContacts);
            this.Controls.Add(this.listViewPersonalContacts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPersonalContacts;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ListView listViewBusinessContacts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ColumnHeader columnPosition;
        private System.Windows.Forms.ColumnHeader columnBirthDate;
        public System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPersonalContact;
        private System.Windows.Forms.Button btnAddBusinessContact;
        private System.Windows.Forms.Button btnDelete;
    }
}

