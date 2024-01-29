using System.Runtime.CompilerServices;

namespace _Esercizio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nel boschetto della mia fantasia c'è un gruppo di animaletti:");

            Animal Alberto = new Animal("Lupo", "Alberto");
            Animal VitelloDaiPiediDiBalsa = new Animal("Vitello", "Vitello dai piedi di Balsa");

            Person Elio = new Person("Umano", "Elio", 56, "176");
            Person Giustino = new Person("Umano", "Giustino", 60, "160");

            Vehicles Thomas = new Vehicles("Veicolo", "Trenino", "Thomas");

            Console.WriteLine(Alberto.GetInfo());
            Console.WriteLine(VitelloDaiPiediDiBalsa.GetInfo());
            Console.WriteLine(Elio.GetInfo());
            Console.WriteLine(Giustino.GetInfo());
            Console.WriteLine(Thomas.GetInfo());

        }
    }
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public Animal(string species, string name)
        {
            Species = species;
            Name = name;
        }

        public string GetInfo()
        {
            return $"Specie: {Species}, Nome: {Name}";
        }
    }
    public class Person
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }

        public Person(string species, string name, int age, string height)
        {
            Species = species;
            Name = name;
            Age = age;
            Height = height;
        }
        public string GetInfo()
        {
            return $"Specie: {Species} Nome: {Name}, Età: {Age}, Height: {Height}";
        }    }

    public class Vehicles
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }

        public Vehicles(string species, string type, string name)
        {
            Species = species;
            Type = type;
            Name = name;
        }

        public string GetInfo()
        {
            return $"Specie: {Species} Nome: {Name}, Modello: {Type}";
        }
    }
}