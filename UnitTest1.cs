namespace xunit_v3_problem;

public class UnitTest1
{
    [Theory, TestData]
    public void Test1(int arg1, int arg2)
    {
        Assert.Equal(3, arg1 + arg2);
    }
}
