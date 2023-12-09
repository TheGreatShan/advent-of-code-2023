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
            for (int j = 1; j < input.Length; j++)
            {
                if (dic.ContainsKey(input.Substring(i, j)))
                {
                    nums.Add(dic[input.Substring(i, j)]);
                    // input = input.Split(input.Substring(i, j))[1];
                    break;
                }
            }

        }

        var result = nums.First().ToString() + nums.Last();
        return int.Parse(result);
    }
}