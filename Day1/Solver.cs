using System.Linq;

namespace Day1;

public static class Solver
{
    public static string GetKey(string encrypted)
    {
        var numbers = "123456789".ToCharArray().ToList();
        var charInput = encrypted.ToCharArray().ToList();
        var resultingNumbers = charInput.Where(numbers.Contains).ToList();

        return resultingNumbers.First().ToString() + resultingNumbers.Last().ToString();
    }

    public static int GetSum(List<string> keys)
    {
        var sum = 0;
        var totalSum = keys.ConvertAll(int.Parse);
        
        foreach (var i in totalSum)
        {
            sum += i;
        }
        return sum;
    }
}
