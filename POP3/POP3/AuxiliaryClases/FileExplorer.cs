using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace POP3
{
    class FileExplorer
    {
        /// <summary>
        /// Open a file exlporer dialog and display the
        /// selected image on the given picture box.
        /// </summary>
        /// <param name="box"></param>
        public static void Open(PictureBox box)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            box.Image = new Bitmap(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
