using System;
using System.Windows.Forms;

using MetroFramework.Controls;
using MetroFramework.Forms;

namespace POP3
{
    public class CustomComboBox: MetroComboBox, ICustomForm
    {

        void ICustomForm.Refresh()
        {
            this.SelectedItem = 0;
        }
    }
}
