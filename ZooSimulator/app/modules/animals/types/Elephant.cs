/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Declaring the Elephant class that will hold any methods or variable
|   specific for the animal.
|
|--------------------------------------*/

namespace ZooSimulator.Animals
{	
	public class Elephant : BaseAnimal
    {
		public Elephant(string name, float health = 100, bool movement = true) : base(name, health, movement)
        { 
			type            = EAnimalType.Elephant;
			minAliveHealth  = 70;
		}

        public override bool IsAlive()
        {
            base.IsAlive();
            bool tempVal = true;

            if (GetHealth < 70)
            {
                if (checkIfAlive > 1)
                {  tempVal = false; }
            }
            else
            { tempVal = true; }

            return tempVal;
        }
    }
}