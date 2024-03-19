using Ripka.Interfaces;

namespace Ripka
{
    internal class StoryController : IStoryController
    {
        public void NewCharacterSurvey(List<BaseCharacter> listCharacter)
        {
            Console.Write("Бажаєте додати ще персонаж? (Y/N): ");
            string userInput = Console.ReadLine();

            switch (userInput.ToUpper())
            {
                case "Y":
                    listCharacter.Add(new BaseCharacter());
                    NewCharacterSurvey(listCharacter); // Рекурсивно викликаєм метод, щоб спитати корсистувача знову
                    break;
                case "N":
                    Console.WriteLine("Тоді залишраємо попередню кількість персонажів");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Неверный ввод.");
                    NewCharacterSurvey(listCharacter); // Рекурсивно викликаєм метод, щоб спитати корсистувача знову
                    break;
            }
        }

        public void PlantChanging(Plant plant)
        {
            StoryIntrodaction(plant);
            Console.Write("Можливо ви бажаєте змінити рослину на іншу? (Y/N): ");
            string userInput = Console.ReadLine();

            switch (userInput.ToUpper())
            {
                case "Y":
                    {
                        plant.setPlant();
                        StoryIntrodaction(plant);
                        break;
                    }
                case "N":
                    {
                        Console.WriteLine("Тоді все ж таки залищаємо сказку про " + plant.PlantName + "...");
                        StoryIntrodaction(plant);
                        break;
                    }
                default:
                    {
                        PlantChanging(plant);
                        break;
                    }
            }
        }

        public void PlantPullingControl(Plant plant)
        {
            Console.Write(plant.PlantName + " вже витягнута? (Y/N): ");
            string userInput = Console.ReadLine();
            Console.ReadLine();

            switch (userInput.ToUpper())
            {
                case "Y":
                    {
                        plant.IsPulled = true;
                        break;
                    }
                case "N":
                    {
                        plant.IsPulled = false;
                        break;
                    }
                default:
                    {
                        PlantPullingControl(plant);
                        break;
                    }
            }
        }


        private void StoryIntrodaction(Plant plant)
        {
            Console.WriteLine("Зараз буде казка про " + plant.PlantName + "!!!");
            Console.ReadLine();
        }


    }
}
