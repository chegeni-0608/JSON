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
using Common.Resources;

namespace JSON
{
    public partial class frmKeyboardEvent : Form
    {
        public frmKeyboardEvent()
        {
            InitializeComponent();
        }


        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
         if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNationalCode, "فقط عدد وارد کنید");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if(txtNationalCode.TextLength < 10)
            {
                errorProvider1.SetError(txtNationalCode, "کد ملی باید ده رقم باشد");
                txtNationalCode.Focus();
            }
        }


        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtFirstName, "فقط حروف وارد کنید");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            //Regex regex = new Regex(@"09\d{9}");
            //if (!regex.IsMatch(txtMobile.Text))
            //{
            //    errorProvider1.SetError(txtMobile, "فرمت شماره اشتباه است");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
           // ChechRegex(@"09\d{9}", txtMobile, "فرمت شماره اشتباه است");
            ChechRegex(@"09\d{9}", txtMobile, Messages.MobileInvalid);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //if (!regex.IsMatch(txtEmail.Text))
            //{
            //    errorProvider1.SetError(txtEmail, "فرمت ایمیل اشتباه است");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}

            //ChechRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", txtEmail, "فرمت ایمیل اشتباه است");
            //ChechRegex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", txtEmail, Messages.EmailInvalid);
            ChechRegex(regexpattern., txtEmail, Messages.EmailInvalid);
        }
        private void ChechRegex(String pattern, TextBox control, string errorMessage)
        {
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(control.Text))
            {
                errorProvider1.SetError(control, errorMessage);
            }
            else
            {
                errorProvider1.Clear();
            }
        }


    }
}
