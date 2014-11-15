using System;
using System.Windows.Forms;

namespace POP3
{
    public class CustomPictureBox: PictureBox, ICustomForm
    {
        /// <summary>
        /// Refresh picture box.
        /// </summary>
        void ICustomForm.Refresh()
        {
            this.Image = this.InitialImage;
        }
    }
}
