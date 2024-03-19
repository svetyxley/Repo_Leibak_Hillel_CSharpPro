using Ripka.Interfaces;

namespace Ripka
{
    internal class MainCharacter : BaseCharacter, IMainCharacter
    {
        public MainCharacter(string CharacterName) : base(CharacterName)
        {
        }

        public bool PlantsPlant(bool isPlanted, string plantName)
        {
            if (!isPlanted)
            {
                Console.WriteLine("Дід саджає " + plantName + "...");
                Console.ReadLine();
                isPlanted = true;
            }
            return isPlanted;
        }

        public bool CheckPlant()
        {
            throw new NotImplementedException();
        }
    }
}
