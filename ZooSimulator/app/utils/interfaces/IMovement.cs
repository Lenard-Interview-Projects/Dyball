/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Interface to be implemented in animal classes
|
|--------------------------------------*/
namespace ZooSimulator.Utils
{
	public interface IMovement
    {	
		bool CanWalk();

		bool IsIdling();
		bool IsWalking();
	}
}