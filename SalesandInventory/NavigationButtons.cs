using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesandInventory
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color selectedColor;


        public NavigationButtons (List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            this.buttons = buttons;
           this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
        } 

        private void setButtonColor()
        {

        }

        public void Highlight(Button selectedButton) {

            foreach (Button button in buttons)
            {
                if (button == selectedButton)
                {
                    selectedButton.BackColor = selectedColor;
                }
                else
                {
                    button.BackColor = defaultColor;
                }
            }
        }
    }
}
