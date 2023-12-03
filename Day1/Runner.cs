namespace Day1;

public static class Runner
{
    public static int Run(string file)
    {
        var input = File.ReadAllLines(file);
        var keys = input.Select(Solver.GetKey).ToList();
        var result = Solver.GetSum(keys);
        return result;
    }
}
