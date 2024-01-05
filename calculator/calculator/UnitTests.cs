using xunit;
public class UnitTests
{
    public void TestAddition()
    {
        // given
        Calculator Calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        // when
        int result = Calc.Add(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }

    public void TestSubtraction()
    {
        // given
        Calculator Calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 3;

        // when
        int result = Calc.Subtract(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }

    public void TestMultiply()
    {
        // given
        Calculator Calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 10;

        // when
        int result = Calc.Multiply(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }

    public void TestDivide()
    {
        // given
        Calculator Calc = new();
        int a = 10;
        int b = 2;
        int expectedResult = 5;

        // when
        int result = Calc.Division(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }
}