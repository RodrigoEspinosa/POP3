using System;
using System.Windows.Forms;

using MetroFramework;

namespace POP3.AuxiliaryClases
{
    public static class ValidationSuccess
    {
        public static DialogResult Show(IWin32Window owner, String message = "OK")
        {
            return MetroFramework.MetroMessageBox.Show(owner, message,
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Show(String message = "OK")
        {
            return MetroFramework.MetroMessageBox.Show(Form.ActiveForm.Owner, message,
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
