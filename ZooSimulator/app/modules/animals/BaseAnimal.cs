/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|
|**Allowing to set the health and movement in the constructor
|	The reason for allowing to change the Helth & Movement are to allow for more customization later one
|	such as, an animal arrives nearly dead at the zoo and they can try and revive it. (By pressing a + button next to their bar)
|
|**Add Health & TakeHealth
|	I have converted the amount to a positive number simply because we don't want to accidently change the health by a negative number.
|
|--------------------------------------*/
using System;
using ZooSimulator.Utils;

namespace ZooSimulator.Animals
{
	public enum EAnimalType {
		Elephant    = 0,
		Monkey      = 1,
		Giraffe     = 2,
	}

    public enum EAnimalHealth
    {
        Healthy = 0,
        Injured = 1,
        Dead = 2,
    }
		
	public class BaseAnimal : IHealth, IMovement {
		private string name;
		private float health;
		private bool isMoving;

        protected EAnimalHealth healthStatus;
		protected EAnimalType type;
		protected float minAliveHealth;
        protected int checkIfAlive;

        public EAnimalType GetHealthStatus   { get { return type; }}
        public EAnimalType GetAnimalType     { get { return type; }}

        public string GetName               { get { return name;        }}				
		public float GetHealth              { get { return health;      }}
        public bool IsMoving                { get { return isMoving;    }}

        // The reason for allowing to change the Helth & Movement are to allow for more customization later one
        // such as, an animal arrives nearly dead at the zoo and they can try and revive it. (By pressing a + button next to their bar)
        public BaseAnimal(string initialName, float initalHealth = 100, bool initialMovement = true) {
			this.name		= initialName;
			this.health 	= initalHealth;
			this.isMoving 	= initialMovement;

            this.checkIfAlive = 0;
        }
	
		// Implementing IHealth Interface
		public void AddHealth(float amount) {
			float posAmount = Math.Abs(amount);
	
			if(health + posAmount < 100)
				health += posAmount;
			else
				health = 100;
            
            if (health >= 100)
                healthStatus = EAnimalHealth.Healthy;
            else if (health >= minAliveHealth)
            {
                checkIfAlive = 0;
                healthStatus = EAnimalHealth.Injured;
            }
		}
		
		public void TakeHealth(float amount) {
			float posAmount = Math.Abs(amount);

            if (health - posAmount > 0) { health -= posAmount; }
            else { health = 0; }

            if (health < 100)
                healthStatus = EAnimalHealth.Injured;
            else if (health <= 0)
                healthStatus = EAnimalHealth.Dead;

		}

        public void CheckIfAlive()
        {
            if (health < minAliveHealth)
                checkIfAlive++;
            else
                checkIfAlive = 0;
        }

		public virtual bool IsAlive() { 	
			return health > minAliveHealth;
		}
		
		// Implementing IMovement interface
		public bool CanWalk() {
            return health >= minAliveHealth;
        }

		public bool IsIdling()  { return isMoving == false; }
		public bool IsWalking() { return isMoving; }
	}
}