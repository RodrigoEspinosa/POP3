using System;
using System.Windows.Forms;

using MetroFramework;

namespace POP3.AuxiliaryClases
{
    public static class ValidationError
    {
        public static DialogResult Show(IWin32Window owner, String message = "Please check input fields.")
        {
            return MetroFramework.MetroMessageBox.Show(owner, message,
                "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
