using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoForm
{
    public partial class InfoDisplayForm : Form
    {
        public InfoDisplayForm()
        {
            InitializeComponent();
        }
        public void setNameText(string text)
        {
            this.nameTextBox.Text = text;
        }
        public void setSurnameText(string text)
        {
            this.surnameTextBox.Text = text;
        }
        public void setEmailText(string text)
        {
            this.emailTextBox.Text = text;
        }
        public void setAgeText(string text)
        {
            this.ageTextBox.Text = text;
        }
    }
}
