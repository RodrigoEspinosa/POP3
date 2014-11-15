using System;
using System.IO;


using System.Windows.Forms;
using MetroFramework.Controls;

using System.Net.Mail;
using System.Collections.Generic;
using POP3;

namespace POP3
{
    public abstract class Verify
    {
        public static void Int(CustomTextBox textBox)
        {
            try
            {
                if (textBox.Text != "")
                {
                    int value = Int32.Parse(textBox.Text);
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("The input should be an intiger!");
                textBox.Text = "";
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("The input can't be that big!");
                textBox.Text = "";
                Console.WriteLine(ex.Message);
            }
        }

        public static void String(CustomTextBox textBox)
        {
            List<String> listedString = new List<String>(textBox.Text.ToString().Split());
            List<String> numericList = new List<String>(new String[] {"0","1","2","3",
                                                                      "4","5","6","7",
                                                                      "8","9"});
            if (textBox.Text != "")
            {
                foreach (String i in listedString)
                {
                    foreach (String n in numericList)
                    {
                        if (i == n)
                        {
                            Console.WriteLine(textBox.Text);
                            textBox.Text = "";
                            MessageBox.Show("The input should be a string!");
                        }
                    }
                }
            }
        }


        public static bool Email(CustomTextBox textBox)
        {
            if (textBox.Text != "")
            {
                try
                {
                    MailAddress email = new MailAddress(textBox.Text);
                    return true;
                }
                catch (FormatException ex)
                {
                    textBox.Text = "";
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Please input a valid email adress!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

