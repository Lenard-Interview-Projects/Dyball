/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Declaring the Giraffe class that will hold any methods or variable
|   specific for the animal.
|
|--------------------------------------*/

namespace ZooSimulator.Animals
{	
	public class Giraffe : BaseAnimal
    {	
		public Giraffe(string name, float health = 100, bool movement = true) : base(name, health, movement)
        {
			type            = EAnimalType.Giraffe;
			minAliveHealth  = 50;
		}
	}
}