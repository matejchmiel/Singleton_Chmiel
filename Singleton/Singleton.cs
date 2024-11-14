public class Singleton
{
// Statické pole pro uložení jediné instance třídy
private static Singleton instance = null;
// Zámek pro zajištění bezpečnosti vláken
private static readonly object padlock = new object();
// Soukromý konstruktor, aby nedošlo k vytvoření instance zvenčí
private Singleton()
{
}
// Veřejná statická vlastnost pro přístup k jediné instanci třídy
public static Singleton Instance
{
get
{
lock (padlock)
{
if (instance == null)
{
instance = new Singleton();
}
return instance;
}
}
}
// Příklad metody v Singletonu
public void DoSomething()
{
Console.WriteLine("Singleton instance is working.");
}
}
