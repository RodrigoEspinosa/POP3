using System;

using MetroFramework.Controls;

namespace POP3.AuxiliaryClases
{
    public abstract class LocationAux
    {
        public static bool TextBoxIsEmpty(CustomTextBox textbox)
        {
            return textbox.Text == "";
        }
        public static String GetName(CustomComboBox comboBox, CustomTextBox textBox)
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
