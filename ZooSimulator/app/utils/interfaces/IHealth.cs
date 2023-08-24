/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Interface to be implemented in animal classes
|
|--------------------------------------*/
namespace ZooSimulator.Utils
{
	public interface IHealth {
        void AddHealth(float amount);
		void TakeHealth(float amount);

		bool IsAlive();
	}
}