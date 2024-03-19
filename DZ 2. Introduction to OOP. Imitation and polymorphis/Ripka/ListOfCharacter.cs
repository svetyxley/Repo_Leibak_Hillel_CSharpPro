using System.ComponentModel.Design;

namespace Ripka
{
    internal class ListOfCharacter
    {
        public List<BaseCharacter> listCharacter = new List<BaseCharacter>();

        //Cteate list of base character
        public void CreateDefaultListOfCharacter()
        {
            listCharacter.Add(new MainCharacter("Did"));
            listCharacter.Add(new BaseCharacter("Babka"));
            listCharacter.Add(new BaseCharacter("Vnuchka"));
            listCharacter.Add(new BaseCharacter("Juchka"));
        }

        //Choose the main chatacter  - Did
        public MainCharacter GetMainCharacter()
        {
            MainCharacter mainCharacter = null;

            foreach (MainCharacter character in listCharacter)
            {
                if (character.CharacterName == "Did")
                {
                    mainCharacter = character;
                    break;
                }
            }
            return mainCharacter;
        }

        //Кожен з персонажів тягне ростину, якщо рослина не витягнута кличе на допомогу
        public void EachCharacterPullOutPlant(Plant plant, StoryController storyController)
        {
            int curentElement = 1;

            foreach (BaseCharacter character in listCharacter)
            {
                if (!plant.IsPulled)
                {
                    curentElement++;
                    character.PullOutPlant(plant, storyController);
                }

                else
                {
                    Console.WriteLine(plant.PlantName + " витягнута!");
                    break;
                }
            }

            if (!plant.IsPulled)
            { 
                Console.WriteLine("Помічники скінчились!"); 
            }
            
            Console.WriteLine("***********");
            Console.WriteLine("THE END");
            Console.WriteLine("***********");
        }
    }    
}
