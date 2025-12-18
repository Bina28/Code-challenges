namespace Code_challenges;

public class Collections
{
    //arrays
    public string[] fruits = ["Apple", "Banana", "Watermelon"];
    public double[] grades = [6.5, 5.5, 4.5, 10.6];
    public int[] numbres = [1, 4, 6, 7, 35667];

    //lists
    public List<int> listOfIntegers = [4, 5, 6, 7];
    public List<string> listOfNames = ["Nina", "Kate", "Ola"];
    public List<double> listOfDoubles = [3.5, 5.5, 6.7, 764.7777];

    //dictionary
    public Dictionary<int, int> dictionaryInt = [];
    public Dictionary<int, string> dictionaryString = [];
    public Dictionary<int, double> dictionaryDouble = [];

    // Constructor to initialize dictionaries from lists
    public Collections()
    {
        AddListofIntegeresToDictionary();
        AddListofStringsToDictionary();
        AddListofDoublesToDictionary();
    }

    public void AddListofIntegeresToDictionary()
    {
        for (int i = 0; i < listOfIntegers.Count; i++)
        {
            dictionaryInt.Add(i, listOfIntegers[i]);
        }
    }

    public void AddListofStringsToDictionary()
    {
        for (int i = 0; i < listOfNames.Count; i++)
        {
            dictionaryString.Add(i, listOfNames[i]);
        }
    }

    public void AddListofDoublesToDictionary()
    {
        for (int i = 0; i < listOfDoubles.Count; i++)
        {
            dictionaryDouble.Add(i, listOfDoubles[i]);
        }
    }

    public static void PrintStringArray(string[] arr)
    {
        foreach (var str in arr)
        {
            Console.WriteLine(str);
        }
    }

    public static void PrintDoubleArray(double[] arr)
    {
        foreach (var num in arr)
        {
            Console.WriteLine(num);
        }
    }
    public static void PrintIntArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.WriteLine(num);
        }
    }

    public static void PrintList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public static void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary) where TKey : notnull
    {
        foreach (var item in dictionary)
        {
            Console.WriteLine($"Key: {item.Key}, value: {item.Value}");
        }
    }
}
