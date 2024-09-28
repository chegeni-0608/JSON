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
            Regex regex = new Regex(@"09\d{9}");
            if(!regex.IsMatch(txtMobile.Text))
            {
                errorProvider1.SetError(txtMobile, "فرمت موبایل اشتباه است");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
