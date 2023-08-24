/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): Main file where we will be setting things up
|
|--------------------------------------*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooSimulator.Animals;
using ZooSimulator.Components;
using ZooSimulator.Utils;

namespace ZooSimulator
{
    public partial class Form1 : Form
    {
        private Dictionary<int, BaseAnimal> animals         = new Dictionary<int, BaseAnimal>();
        private Dictionary<int, UIAnimalRow> animalRows     = new Dictionary<int, UIAnimalRow>();

        private LoadFonts       customFonts;
        private DateManager     currentDate;
        private AnimalsManager  animalsManager;

        private int minutesPassed = 0;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// We want to initialize all the classes used here first before trying to access them
        /// </summary>
        private void Initialize()
        {
            customFonts     = new LoadFonts();
            currentDate     = new DateManager();
            animalsManager  = new AnimalsManager(animals);
        }

        /// <summary>
        /// Inside the load method we are setting up our current date value and format
        /// We are also adding all our animals to the menu and adding the UI element to a Dictionary
        /// for later use.
        /// 
        /// In case any of the classes has not been initialzed we will try to re-initialize them and return an error message
        /// for the developer.
        /// </summary>
        private void ZooSimulator_Load(object sender, EventArgs e)
        {
            try
            { 
                if(currentDate == null || customFonts == null || animalsManager == null)
                    throw new ArgumentNullException();
                
                labelCurrentTimeClock.Font = new Font(customFonts.Font.Families[0], labelCurrentTimeClock.Font.Size);
                labelCurrentTimeClock.Text = currentDate.GetTime;

                labelCurrentTimeStamp.Font = new Font(customFonts.Font.Families[0], labelCurrentTimeStamp.Font.Size);
                labelCurrentTimeStamp.Text = currentDate.GetTimeStamp;

                labelCurrentDate.Font = new Font(customFonts.Font.Families[0], labelCurrentDate.Font.Size);
                labelCurrentDate.Text = currentDate.GetDate;

                labelCurrentDay.Font = new Font(customFonts.Font.Families[0], labelCurrentDay.Font.Size);
                labelCurrentDay.Text = currentDate.GetDay;

                labelGiraffeText.Font = new Font(customFonts.Font.Families[1], labelGiraffeText.Font.Size);
                labelElephantText.Font = new Font(customFonts.Font.Families[1], labelElephantText.Font.Size);
                labelMonkeyText.Font = new Font(customFonts.Font.Families[1], labelMonkeyText.Font.Size);

                int count = 0;
                foreach (KeyValuePair<int, BaseAnimal> animal in animals)
                {
                    UIAnimalRow tempRow = new UIAnimalRow();

                    if (count % 5 == 0)
                    {
                        UIAnimalHeader tempHeader = new UIAnimalHeader();
                        tempHeader.CreateRowHeader(animal.Value, customFonts.Font.Families[1], count).Parent = flowAnimalsList;
                    }

                    tempRow.CreateRow(animal.Value, customFonts.Font.Families[1], count).Parent = flowAnimalsList;
                    animalRows.Add(animal.Key, tempRow);
                    count++;
                }

                Console.WriteLine(currentDate.GetTime);
            }
            catch(Exception exp)
            {
                Initialize();
                Console.WriteLine("{0} CurrentDate or CustomFonts or AnimalsManager are NULL, will try to iniatialize them again.", exp);
            }
        }

        /// <summary>
        /// The dateTimer will be called every 20000 milliseconds (20 sec) which will increase the current date
        /// by an hour and update the UI date as well.
        /// 
        /// We are also enableing the takeHealth timer as we want to be taking about an amount of health from each
        /// animal every hour (20 sec)
        /// </summary>
        private void dateTimer_Tick(object sender, EventArgs e)
        {
            if (currentDate == null)
                return;

            minutesPassed++;

            currentDate.AddMinutes();
            currentDate.UpdateDateUI(labelCurrentDate, labelCurrentDay, labelCurrentTimeClock, labelCurrentTimeStamp);

            if (minutesPassed == 60)
            {
                takeHealth.Enabled = true;
                minutesPassed = 0;
            }
        }

        /// <summary>
        /// We use the takeHealth timer to assign a random and more unique value to each animal
        /// as setting it inside the dateTimer they would all have 99% of the time the same value
        /// deducated from their health.
        /// </summary>
        int animalTakeKey = 0;
        private void takeHealth_Tick(object sender, EventArgs e)
        {
            if(animals[animalTakeKey].IsAlive())
            {
                animals[animalTakeKey].TakeHealth(new Random().Next(0, 20));
                animals[animalTakeKey].CheckIfAlive();

                animalRows[animalTakeKey].Update();
            }

            if (animalTakeKey < animals.Count - 1)
                animalTakeKey++;
            else
            {
                animalTakeKey = 0;
                takeHealth.Enabled = false;
            }
        }

        /// <summary>
        /// When we are clicking the FeedZoo button we create 3 variable to hold the health that will be
        /// given to each animal type.
        /// </summary>
        private async void btnFeedZoo_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int typeOne = random.Next(10, 25);
            await Task.Delay(100);

            int typeTwo = random.Next(10, 25);
            await Task.Delay(100);

            int typeThree = random.Next(10, 25);
            await Task.Delay(100);

            foreach (KeyValuePair<int, BaseAnimal> animal in animals)
            {
                if(animal.Value.IsAlive())
                {
                    switch (animal.Value.GetAnimalType)
                    {
                        case EAnimalType.Giraffe:
                            animal.Value.AddHealth(typeOne);
                            break;
                        case EAnimalType.Elephant:
                            animal.Value.AddHealth(typeTwo);
                            break;
                        case EAnimalType.Monkey:
                            animal.Value.AddHealth(typeThree);
                            break;
                    }

                    animalRows[animal.Key].Update();
                }
            }
        }
    }
}
