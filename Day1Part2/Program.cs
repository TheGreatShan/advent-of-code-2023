using Day1;
using Day1Part2;

public class Program
{
    public static void Main(string[] args)
    {
        var input = FileReader.ReadFiles("input.txt");
        var resultList = input.Select(i => Solver.GetSum(i)).ToList();

        Console.WriteLine(resultList.Sum());
    }
}