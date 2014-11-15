using System;
using System.Windows.Forms;

namespace POP3
{
    public class CustomPictureBox: PictureBox, ICustomForm
    {
        void ICustomForm.Refresh()
        {
            this.Image = this.InitialImage;
        }
    }
}
