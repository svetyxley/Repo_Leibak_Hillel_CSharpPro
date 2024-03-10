namespace HW1_Create_first_class
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; } = 30;
        public Gender UserGender { get; set; }


        public enum Gender
        {
            Meile,
            Femail
        };

        public User() { }

        public User(string FirstName, string LastName, int Age, Gender UserGender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.UserGender = UserGender;
        }

        public void PrintUser()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public string InputFirstName()
        {
            Console.Write("Input First Name: ");
            FirstName = Console.ReadLine() ?? "Unknown";
            if (FirstName == "" || FirstName == " " ) { FirstName = "Unknown"; };
            return FirstName;
        }

        public string InputLastName()
        {
            Console.Write("Input Last Name: ");
            LastName = Console.ReadLine() ?? "Unknown";
            if (LastName == "" || LastName == " ") { LastName = "Unknown"; };
            return LastName;
        }

        public override string ToString()
        {
            return "Hi, my name is " + this.FirstName + " " + this.LastName + ". I am " + this.Age + " years old. I am " + this.UserGender + ".";
        }
    }
}
