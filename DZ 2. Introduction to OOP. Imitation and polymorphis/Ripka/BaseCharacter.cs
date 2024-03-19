using Ripka.Interfaces;

namespace Ripka
{
    internal class BaseCharacter : IBaseCharacter
    {
        public string CharacterName { get; set; }

        public BaseCharacter(string CharacterName) 
        {
            this.CharacterName = CharacterName;
        }

        public BaseCharacter()
        {
            Console.Write("Додайте ім'я нового персонажу: ");
            CharacterName = Console.ReadLine();
        }

        public void PullOutPlant(Plant plant, StoryController storyController)
        {
            Console.WriteLine(CharacterName + " тягне " + plant.PlantName);
            storyController.PlantPullingControl(plant);
            if (!plant.IsPulled)
            {
                CallHelp();
            }
        }

        public void CallHelp()
        {
            Console.WriteLine(CharacterName + " зове на допомогу");
            Console.ReadLine();
        }

    }
}
