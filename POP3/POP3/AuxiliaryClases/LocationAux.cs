using System;

using MetroFramework.Controls;

namespace POP3.AuxiliaryClases
{
    public abstract class LocationAux
    {
        /// <summary>
        /// Returs true if textbox text is empty.
        /// </summary>
        /// <param name="textbox"></param>
        /// <returns>bool</returns>
        public static bool TextBoxIsEmpty(CustomTextBox textbox)
        {
            return textbox.Text == "";
        }

        /// <summary>
        /// Gets the locations name
        /// while handling the controls.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="textBox"></param>
        /// <returns>locations name</returns>
        public static String GetLocationName(CustomComboBox comboBox, CustomTextBox textBox)
        {
            if (comboBox.SelectedIndex != -1 && comboBox.Enabled)
            {
                return comboBox.SelectedItem.ToString();
            }
            else if (!TextBoxIsEmpty(textBox) && textBox.Enabled)
            {
                return textBox.Text;
            }
            else
            {
                throw new Exception("Error");
            }
        }

    }
}
