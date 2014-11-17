using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Net.Mail;
using System.Collections.Generic;

using POP3;
using POP3.AuxiliaryClases;

namespace POP3
{
    public static class Verify
    {
        /// <summary>
        /// Verify whether a string is numeric or not.
        /// </summary>
        /// <param name="textBox"></param>
        public static void Int(CustomTextBox textBox)
        {
            try
            {
                if (textBox.Text != "") {
                    int value = Int32.Parse(textBox.Text);
                }

            } catch (FormatException) {
                textBox.Text = "";
                ValidationError.Show("The input should be an intiger!");
            } catch (OverflowException) {
                textBox.Text = "";
                ValidationError.Show("The input can't be that big!");
            }
        }


        /// <summary>
        /// Verify whether a string is has numbers or not.
        /// </summary>
        /// <param name="textBox"></param>
        public static void String(CustomTextBox textBox)
        {
            if (textBox.Text.Trim() == "") {
                ValidationError.Show ("This field can not be empty.");
            }
        }


        /// <summary>
        /// Verify whether a string is a valid
        /// email address or not.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>bool</returns>
        public static bool Email(CustomTextBox textBox)
        {
            if (textBox.Text != "") {
                try
                {
                    MailAddress email = new MailAddress(textBox.Text);
                    return true;
                } catch (FormatException) {
                    textBox.Text = "";
                    ValidationError.Show("Please input a valid email adress!");
                    return false;
                }
            } else {
                return false;
            }
        }
    }
}

