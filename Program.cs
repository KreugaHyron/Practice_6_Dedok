// See https://aka.ms/new-console-template for more information
using Practice_6_Dedok;
//1
Console.WriteLine("Task_1: ");
UkrainianGermanDictionary dict = new UkrainianGermanDictionary();

dict.AddWord("сонце", new List<string> { "Sonne" });
dict.AddWord("місяць", new List<string> { "Mond", "Monat" });
dict.SearchWord("сонце");

dict.UpdateTranslation("місяць", "Mond", "Monat");
dict.SearchWord("місяць");

dict.RemoveTranslations("місяць", new List<string> { "Monat" });
dict.SearchWord("місяць");

dict.UpdateWord("сонце", "світило");
dict.SearchWord("світило");

dict.RemoveWord("місяць");
dict.SearchWord("місяць");
Console.WriteLine();
//2
Console.WriteLine("Task_2: ");
static T MaxOfThree<T>(T a, T b, T c) where T : IComparable<T>
{
    T max = a;

    if (b.CompareTo(max) > 0)
    {
        max = b;
    }

    if (c.CompareTo(max) > 0)
    {
        max = c;
    }

    return max;

}
int maxInt = MaxOfThree(19, 20, 15);
double maxDouble = MaxOfThree(3.14, 2.71, 1.61);
string maxString = MaxOfThree("apple", "orange", "banana");

Console.WriteLine($"Максимальне ціле: {maxInt}");
Console.WriteLine($"Максимальне дробове: {maxDouble}");
Console.WriteLine($"Максимальний рядок: {maxString}");
Console.WriteLine();
//3
Console.WriteLine("Task_3: ");
Oceanarium oceanarium = new Oceanarium();

oceanarium.AddSeaCreature(new Fish("Clownfish"));
oceanarium.AddSeaCreature(new Jellyfish("Moon Jelly"));
oceanarium.AddSeaCreature(new Turtle("Green Sea Turtle"));

foreach (var creature in oceanarium)
{
    Console.WriteLine(creature);
}