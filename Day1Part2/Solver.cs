namespace Day1Part2;

public static class Solver
{
    public static int GetSum(string input)
    {
        var dic = new Dictionary<string, int>()
        {
            { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 }, { "five", 5 }, { "six", 6 }, { "seven", 7 },
            { "eight", 8 }, { "nine", 9 }, { "1", 1 }, { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 },
            { "7", 7 }, { "8", 8 }, { "9", 9 }
        };
        var nums = new List<int>();
        
        for (var i = 0; i < input.Length; i++)
        {
            for (var j = 1; j <= input.Length - i; j++)
            {
                if (!dic.ContainsKey(input.Substring(i, j))) continue;
                nums.Add(dic[input.Substring(i, j)]);
                break;
            }

        }

        var result = nums.FirstOrDefault().ToString() + nums.LastOrDefault();
        return int.Parse(result);
    }
}