using System;
using System.Windows.Forms;

using MetroFramework.Controls;
using MetroFramework.Forms;

namespace POP3
{
    public class CustomTextBox: MetroTextBox, ICustomForm
    {
        /// <summary>
        /// return the
        /// </summary>
        /// <returns></returns>
        public bool IsTextIntiger()
        {
            int n;
            if (Int32.TryParse(this.Text, out n))
            {
                return n == 0;
            }
            else return true;
           
        }

        /// <summary>
        /// Refresh the text.
        /// </summary>
        public new void Refresh()
        {
            this.Text = "";
        }
    }
}
