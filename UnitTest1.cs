using Xunit;
using Lab3Lib;
using System.ComponentModel.Design.Serialization;

namespace Lab3LibTest;

public class UnitTest1
{
    [Fact]
    public void TestMaxof2Nums()
    {
        int a = 5;
        int b = 6;

        int expected = 6;
        int actual = Root.findMax(a, b);
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestMaxof3Nums()
    {
        int a = 5;
        int b = 6;
        int c = 7;

        int expected = 7;
        int actual = Root.findMax(a, b, c);
        Assert.Equal(expected, actual);
    }
}