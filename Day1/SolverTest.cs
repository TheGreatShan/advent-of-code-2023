namespace Day1;

public class SolverTest
{
    [Fact]
    void should_return_first_and_last_number()
    {
        var actual = Solver.GetKey("dfhdjfh134dhfsj7h");
        Assert.Equal("17", actual);
    }

    [Fact]
    public void should_return_sum()
    {
        var keys = new List<string>{"45", "34"};

        var actual = Solver.GetSum(keys);

        Assert.Equal(79, actual);
    }
}
