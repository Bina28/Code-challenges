namespace Code_challenges;

public class Variables(string name, int age, double height, char grade, bool isStuding)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public double Height { get; set; } = height;
    public char Grade { get; set; } = grade;
    public bool IsStuding { get; set; } = isStuding;
}
