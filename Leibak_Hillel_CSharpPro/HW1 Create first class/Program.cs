/*
ДЗ 1. Створення першого класу

1.Додати клас User

2. Додати проперті

     FirstName - текствого типу

     LastName - текствого типу

     Age - число (це проперті не можна змінювати, подумайте як це зробити)

    Gender - тип що має тільки 2 значення: Male; Female(подумайте що це за тип даних)

3.Додати конструктор

   дефолтний(без параметрів)

   конструктор що задає FirstName, LastName, Age, Gender

4.У класі Program створити об'єкт User - user1

5.Задати йому Gender.

6.Дати можливість користувачу ввести дані для user1

   FirstName

   LastName

7.Вивести дані по user1 на екран.

Додатково на + бали:

Зробіть оверрайд(override) методу ToString() для класу User, так щоб він виводив інфу по юзеру ось так:

Hi, my name is {FirstName} and last name {LastName}. I am {20} years old. I am { Gender }.
*/

namespace HW1_Create_first_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var defaultUser = new User("Default", "User", 20 , User.Gender.Meile);
            var user1 = new User();

            defaultUser.PrintUser(); // вивід дефолтного юзера
            Console.WriteLine();

            // додавання юзера через консоль та його вивід
            // вихід з додатку по ESC
            do {
                user1.InputFirstName();
                user1.InputLastName();
                user1.UserGender = User.Gender.Femail;
                user1.PrintUser();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
