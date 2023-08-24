/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Because we are creating all the UI programmatically it made the most sense
|   to keep it separate from the main file to not cluster it any more than it already is
|
|   From here we can also update the UI as we have bassed the animal object as reference (by default)
|   to this class.
|--------------------------------------*/
using System;
using System.Drawing;
using System.Windows.Forms;
using ZooSimulator.Animals;

namespace ZooSimulator.Components
{
    public class UIAnimalRow
    {
        public BaseAnimal selectedAnimal;

        public Panel rowContainer;
        private Label animalName;
        private ProgressBar animalHealth;
        private PictureBox animalHealthIcon;
        private PictureBox animalMovementIcon;
        
        public Panel CreateRow(BaseAnimal animal, FontFamily font, int index = -1)
        {
            selectedAnimal = animal;

            /** Row Container */
            rowContainer            = new Panel();
            rowContainer.Width      = 269;
            rowContainer.Height     = 40;
            rowContainer.BackColor  = (index % 2 == 0) ? Color.LightGray : Color.WhiteSmoke;
            rowContainer.Margin     = new Padding(0, 0, 0, 0);

            /** Animal Name */
            animalName          = new Label();
            animalName.Width    = 204;
            animalName.Height   = 30;
            animalName.Padding  = new Padding(5, 0, 0, 0);

            animalName.TextAlign    = ContentAlignment.MiddleLeft;
            animalName.Text         = animal.GetName;
            animalName.Font         = new Font(font, 15);
            animalName.ForeColor    = Color.Black;

            animalName.UseCompatibleTextRendering   = true;
            animalName.Parent                       = rowContainer;

            /** Movement Icon */
            animalMovementIcon          = new PictureBox();
            animalMovementIcon.Width    = 30;
            animalMovementIcon.Height   = 30;
            animalMovementIcon.Left     = 205;
            animalMovementIcon.Anchor   = AnchorStyles.Right;

            animalMovementIcon.BackgroundImage = Properties.Resources.cannot_walk_icon;
            animalMovementIcon.BackgroundImageLayout    = ImageLayout.Center;

            animalMovementIcon.Visible  = false;
            animalMovementIcon.Parent   = rowContainer;

            /** Health Icon */
            animalHealthIcon            = new PictureBox();
            animalHealthIcon.Width      = 30;
            animalHealthIcon.Height     = 30;
            animalHealthIcon.Left       = 235;
            animalHealthIcon.Anchor     = AnchorStyles.Right;

            animalHealthIcon.BackgroundImage = (animal.IsAlive()) ? Properties.Resources.alive_icon : Properties.Resources.dead_icon;
            animalHealthIcon.BackgroundImageLayout  = ImageLayout.Center;

            animalHealthIcon.Parent = rowContainer;

            /** Animal Health Progress Bar */
            animalHealth        = new ProgressBar();
            animalHealth.Width  = 269;
            animalHealth.Height = 8;
            animalHealth.Top    = 32;
            animalHealth.Value  = (int)animal.GetHealth;

            animalHealth.Parent = rowContainer;

            return rowContainer;
        }

        public void Update()
        {
            animalName.Text     = selectedAnimal.GetName;
            animalHealth.Value  = (int)selectedAnimal.GetHealth;

            animalHealthIcon.BackgroundImage = (selectedAnimal.IsAlive()) ? Properties.Resources.alive_icon : Properties.Resources.dead_icon;
            animalMovementIcon.Visible          = (selectedAnimal.CanWalk()) ? false : true;
        }
    }
}
