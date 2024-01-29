namespace _Esercizio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nel boschetto della mia fantasia c'è un gruppo di animaletti:");

            Animal Alberto = new Animal("Lupo", "Alberto", "ruba galline");
            Animal VitelloDaiPiediDiBalsa = new Animal("Vitello", "Vitello dai piedi di Balsa", "inventore di una storia falsa");
            Animal Leone = new Animal("Cane", "Leone", "Marilù, ti salverò!");

            Person Elio = new Person("Umano", "Elio", 56, "176", "");
            Person Giustino = new Person("Umano", "Giustino", 60, "160", "Marilù!! Dov'è la mia cena?");
            Person Filippo = new Person("Umano", "Filippo", 35, "175", "e mi ballo la fresca" );

            Vehicles Thomas = new Vehicles("Veicolo", "Trenino", "Thomas", "Ciuuuuuuf ciuuuuuuuuf");

            Console.WriteLine(Alberto.Greet());
            Console.WriteLine(VitelloDaiPiediDiBalsa.Greet());
            Console.WriteLine(Elio.GetInfo());
            Console.WriteLine(Giustino.Greet());
            Console.WriteLine(Leone.Greet());
            Console.WriteLine(Thomas.Greet());
            Console.WriteLine(Filippo.Greet());
        }
    }
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }

        public Animal(string species, string name, string action)
        {
            Species = species;
            Name = name;
            Action = action;
        }

        public string GetInfo()
        {
            return $"Specie: {Species}, Nome: {Name}";
        }

        public string Greet()
        {
            return $"Ciao, sono {Name}, un {Species}, {Action}";
        }
    }
    public class Person
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }

        public string Action;

        public Person(string species, string name, int age, string height, string action)
        {
            Species = species;
            Name = name;
            Age = age;
            Height = height;
            Action = action;
        }
        public string GetInfo()
        {
            return $"Specie: {Species} Nome: {Name}, Età: {Age}, Height: {Height}";
        }

        public string Greet()
        {
            return $"Ciao, sono {Name}, un {Species} alto {Height}, {Action}";
        }

    }

    public class Vehicles
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string Action {get; set; }

        public Vehicles(string species, string type, string name, string action)
        {
            Species = species;
            Type = type;
            Name = name;
            Action = action;
        }

        public string GetInfo()
        {
            return $"Specie: {Species} Nome: {Name}, Modello: {Type}";
        }

        public string Greet()
        {
            return $"{Action} Sono il {Type} {Name}";
        }
    }
}