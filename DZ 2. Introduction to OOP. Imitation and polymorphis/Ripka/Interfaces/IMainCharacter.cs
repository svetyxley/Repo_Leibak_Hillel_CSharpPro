namespace Ripka.Interfaces
{
    interface IMainCharacter : IBaseCharacter
    {
        bool PlantsPlant(bool isPlanted, string plantName);
        bool CheckPlant();
    }
}
