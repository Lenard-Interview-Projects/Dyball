/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   To keep things more organized we split the creation of each animal in a seperate file
|
|   Since we are giving each animal an individual name we are creating them based on a 
|   list of names stored in a static class which can be used from anywhere.
|
|--------------------------------------*/
using System.Collections.Generic;
using ZooSimulator.Utils;

namespace ZooSimulator.Animals
{
    public class AnimalsManager
    {
        public AnimalsManager(Dictionary<int, BaseAnimal> animals)
        {
            for (int count = 0; count < NamesList.Names.Count; count++)
            {
                if (count < 5)
                    animals.Add(count, new Giraffe(NamesList.Names[count]));
                else if (count >= 5 && count < 10)
                    animals.Add(count, new Elephant(NamesList.Names[count]));
                else
                    animals.Add(count, new Monkey(NamesList.Names[count]));
            }
        }
    }
}
