/*1.ООП казка про Ріпку. Жартівна реалізація казки про ріпку.

- є персонажі: Дід, Бабця, Онучка, Жучка тощо.

- є рослина Ріпка

- персонажі можуть тягнути рослину і кликати на допомогу, якщо не виходить витягнути.

- загальний хід казки наступний: Дід садить ріпку, ріпка росте, потім Дід намагається її витягнути, і якщо не може, кличе наступного персонажа, і так далі, поки ріпка не буде витягнута, або поки персонажі не закінчаться.

- "Міцність" або "Вага" ріпки визначається на етапі її зростання.

- У коді має залишатися можливість замінити рослину іншою. А також - додавати персонажів.*/

namespace Ripka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfCharacter = new ListOfCharacter();
            var storyController = new StoryController();
            var plant = new Plant("Ripka", false, false, 0); //Дефолтні налаштування для рослини

            //Create list of main characters
            listOfCharacter.CreateDefaultListOfCharacter();

            //Begin to tell a story with ability to change a plant
            storyController.PlantChanging(plant);

            //Additional characters
            storyController.NewCharacterSurvey(listOfCharacter.listCharacter);

            //If the plant isn't planted, Did plants this plant
            listOfCharacter.GetMainCharacter().PlantsPlant(plant.IsPlanted, plant.PlantName);

            //Plant grows
            plant.PlantGrows(plant.Weight);

            //pull out the plant and call for help
            listOfCharacter.EachCharacterPullOutPlant(plant, storyController);

        }
    }
}
