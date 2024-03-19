using Ripka.Interfaces;

namespace Ripka
{
    internal class Plant : IPlant
    {
        public string PlantName { get; set; }
        public bool IsPlanted { get; set; }

        public bool IsPulled { get; set; }
        public int Weight { get; private set; }
        public Plant(string PlantName, bool IsPlanted, bool IsPulled, int Weight) 
        {
            this.PlantName = PlantName;
            this.IsPlanted = IsPlanted;
            this.IsPulled = IsPulled;   
            this.Weight = Weight;
        }
        public string setPlant() 
        {
            Console.Write("Введіть назву рослини: ");
            PlantName = Console.ReadLine();
            Console.ReadLine();
            return PlantName;
        }

        public int PlantGrows(int Weight)
        {
            do
            {
                Console.WriteLine(PlantName + "  зростає..");
                Console.WriteLine(PlantName + " важить " + this.Weight + "кг");
                Console.ReadLine();
                this.Weight++;
            }
            while (this.Weight <= 5);
            Console.WriteLine("Пора збирати врожай");
            return Weight;
        }
    }
}
