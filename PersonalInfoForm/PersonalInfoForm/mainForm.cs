using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoForm
{
    public partial class MainForm : Form
    {
        InfoDisplayForm infoDisplayForm;
        public MainForm()
        {
            InitializeComponent();
            infoDisplayForm = new InfoDisplayForm();
            this.setDateBounds();
        }

        private void setDateBounds()
        {
            this.dateTimePicker.MaxDate = DateTime.Today.AddYears(-1);
            this.dateTimePicker.MinDate = DateTime.Today.AddYears(-120);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            validateField((TextBox)sender, validateName);
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            validateField((TextBox)sender, validateName);
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            validateField((TextBox)sender, validateEmail);
        }
        private void validateField(TextBox textBox, Func<string, bool> validator)
        {
            bool isValid = validator(textBox.Text);
            if (isValid)
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = Color.Red;
            }
        }
        private bool validateName(string name)
        {
            if (name == null || name == "")
            {
                this.writeInfo("Name/Surname is required.");
                return false;
            }
            string pattern = $"^[A-ZŠČŘŽÚ]+(([',. -][a-zA-Zěščřžýáíéúů ])?[a-zA-Zěščřžýáíéúů]*)*";
            Regex mRegex = new Regex(pattern);
            string rest = mRegex.Replace(name, "", 1);
            if (rest.Length > 0)
            {
                this.writeInfo($"Invalid character: \"{rest[0]}\"");
                return false;
            }
            else
            {
                this.writeInfo("Name / Surname");
                return true;
            }
        }
        private bool validateEmail(string email)
        {
            if (email == null)
            {
                this.writeInfo("Email is required.");
                return false;
            }
            try
            {
                new System.Net.Mail.MailAddress(email);
                this.writeInfo("");
                return true;
            }
            catch (ArgumentException)
            {
                this.writeInfo("Email is required.");
                return false;
            }
            catch (FormatException)
            {
                this.writeInfo("Email is invalid.");
                return false;
            }
        }
        private void writeInfo(string text)
        {
            this.infoLabel.Text = text;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string[] invalidFields = getInvalidFields();
            if (invalidFields.Length > 0)
            {
                this.writeInfo($"Invalid fields: {String.Join(", ", invalidFields)}");
            } else
            {
                if (infoDisplayForm.IsDisposed)
                {
                    infoDisplayForm = new InfoDisplayForm();
                }
                if (infoDisplayForm.Visible == false)
                {
                    infoDisplayForm.Show();
                }
                infoDisplayForm.setNameText(this.nameTextBox.Text);
                infoDisplayForm.setSurnameText(this.surnameTextBox.Text);
                infoDisplayForm.setEmailText(this.emailTextBox.Text);
                double hours = DateTime.Today.Subtract(DateTime.Parse(this.dateTimePicker.Text)).TotalDays;
                double age = Math.Round(hours / 365, 1);
                infoDisplayForm.setAgeText(age.ToString());
            }
        }
        private string[] getInvalidFields()
        {
            List<string> invalidFields = new List<string>();
            bool isNameValid = this.validateName(this.nameTextBox.Text);
            bool isSurnameValid = this.validateName(this.surnameTextBox.Text);
            bool isEmailValid = this.validateEmail(this.emailTextBox.Text);
            if (isNameValid == false)
            {
                invalidFields.Add("Name");
            }
            if (isSurnameValid == false)
            {
                invalidFields.Add("Surname");
            }
            if (isEmailValid == false)
            {
                invalidFields.Add("Email");
            }
            return invalidFields.ToArray();
        }
    }
}
