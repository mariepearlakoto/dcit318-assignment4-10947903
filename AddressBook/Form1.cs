﻿using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
