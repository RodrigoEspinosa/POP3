using System;
using System.Windows.Forms;

using MetroFramework.Controls;
using MetroFramework.Forms;

namespace POP3
{
    public class CustomComboBox: MetroComboBox, ICustomForm
    {

        /// <summary>
        /// Refresh combo box.
        /// </summary>
        void ICustomForm.Refresh()
        {
            this.SelectedItem = 0;
        }
    }
}
