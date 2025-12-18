using Code_challenges;

//oppgave 1
var oppgave1 = new Variables("Fiona", 24, 1.76, 'B', true);
Console.WriteLine($"Person's name: {oppgave1.Name}\nPerson's age: {oppgave1.Age}\nPerson's height: {oppgave1.Height}\n" +
    $"Person's grade: {oppgave1.Grade}\nIs person studing:{oppgave1.IsStuding}");

Console.WriteLine("Press any key to enter the Calculator Game!");
Console.ReadLine();

//oppgave2
Calculator.Run();
Console.Clear();
Console.WriteLine("Press any key to see task 3");
Console.ReadLine();

//oppgave3
Console.Clear();
Collections collections = new();

Console.WriteLine("Array of strings:");
Collections.PrintStringArray(collections.fruits);

Console.WriteLine("Array of doubles:");
Collections.PrintDoubleArray(collections.grades);

Console.WriteLine("Array of integers:");
Collections.PrintIntArray(collections.numbres);

Console.WriteLine("List of strings:");
Collections.PrintList(collections.listOfNames);

Console.WriteLine("List of doubles:");
Collections.PrintList(collections.listOfDoubles);

Console.WriteLine("List of integers: ");
Collections.PrintList(collections.listOfIntegers);

Console.WriteLine("Dictionary of strings:");
Collections.PrintDictionary(collections.dictionaryString);

Console.WriteLine("Dictionary of doubles:");
Collections.PrintDictionary(collections.dictionaryDouble);

Console.WriteLine("Dictionary of integers: ");
Collections.PrintDictionary(collections.dictionaryInt);