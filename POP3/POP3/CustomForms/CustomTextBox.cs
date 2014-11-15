using System;
using System.Windows.Forms;

using MetroFramework.Controls;
using MetroFramework.Forms;

namespace POP3
{
    public class CustomTextBox: MetroTextBox, ICustomForm
    {
        /// <summary>
        /// Refresh the text box.
        /// </summary>
        public new void Refresh()
        {
            this.Text = "";
        }
    }
}
