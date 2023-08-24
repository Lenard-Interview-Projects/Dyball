/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Declaring the Monkey class that will hold any methods or variable
|   specific for the animal.
|
|--------------------------------------*/

namespace ZooSimulator.Animals
{	
	public class Monkey : BaseAnimal
    {	
		public Monkey(string name, float health = 100, bool movement = true) : base(name, health, movement)
        { 
			type            = EAnimalType.Monkey;
			minAliveHealth  = 30;
		}
	}
}