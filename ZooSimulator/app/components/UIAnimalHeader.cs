/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Because we are creating all the UI programmatically it made the most sense
|   to keep it separate from the main file to not cluster it any more than it already is
|--------------------------------------*/
using System.Drawing;
using System.Windows.Forms;
using ZooSimulator.Animals;

namespace ZooSimulator.Components
{
    public class UIAnimalHeader
    {
        public Panel CreateRowHeader(BaseAnimal animal, FontFamily font, int index = -1)
        {
            Panel tempRow   = new Panel();
            tempRow.Width   = 269;
            tempRow.Height  = 40;
            tempRow.Margin  = new Padding(0, (index == 0) ? 0 : 5, 0, 0);

            tempRow.BackColor   = Color.Firebrick;

            PictureBox icon = new PictureBox();
            icon.Width      = 40;
            icon.Height     = 40;

            icon.BackgroundImageLayout  = ImageLayout.Center;
            icon.Parent                 = tempRow;

            Label text  = new Label();
            text.Width  = 214;
            text.Height = 40;
            text.Left   = 45;

            text.TextAlign  = ContentAlignment.MiddleLeft;
            text.Text       = animal.GetAnimalType.ToString();
            text.Font       = new Font(font, 25);
            text.ForeColor  = Color.White;

            text.UseCompatibleTextRendering = true;
            text.Parent                     = tempRow;

            switch (animal.GetAnimalType)
            {
                case EAnimalType.Elephant:
                    icon.BackgroundImage = Properties.Resources.elephant_icon;
                    text.Text               = "Elephant";
                    break;
                case EAnimalType.Giraffe:
                    icon.BackgroundImage = Properties.Resources.giraffe_icon;
                    text.Text               = "Giraffe";
                    break;
                case EAnimalType.Monkey:
                    icon.BackgroundImage = Properties.Resources.monkey_icon;
                    text.Text               = "Monkey";
                    break;
                default:
                    text.Text = "Undefined";
                    break;
            }

            return tempRow;
        }
    }
}
