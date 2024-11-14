using System;
using S_Chmiel;

namespace S_Chmiel
{
    public class Singleton
    {
        // Soukromý statický atribut pro uchovávání jediné instance třídy
        private static Singleton instance;

        // Soukromý konstruktor, aby nebylo možné vytvářet nové instance zvenčí
        private Singleton() { }

        // Veřejná statická metoda pro získání jediné instance třídy
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Metoda pro demonstrování použití Singletonu
        public void ShowMessage()
        {
            Console.WriteLine("Toto je zpráva ze Singletonu.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Získání instance Singletonu a volání metody ShowMessage
            Singleton singleton1 = Singleton.GetInstance();
            singleton1.ShowMessage();

            // Získání další instance Singletonu a ověření, že je stejná jako první
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Obě instance jsou stejné.");
            }
            else
            {
                Console.WriteLine("Instance nejsou stejné.");
            }
        }
    }
}
