using System.ComponentModel;

namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal(15, "Lion", "рык");
            Animal elephant = new Animal(25, "Elephant", "трубление");
            Animal wolf = new Animal(10, "Wolf", "вой");
            Animal tiger = new Animal(14, "Tiger", "рык");
            Animal cow = new Animal(23, "Cow", "мычание");

            List<Animal> animals = new List<Animal>() { lion, elephant, wolf};
            UserList userList = new UserList(animals);

            userList.Add(tiger);
            Console.WriteLine(new string('-', 50));
            userList.Add(cow);
        }
    }


}