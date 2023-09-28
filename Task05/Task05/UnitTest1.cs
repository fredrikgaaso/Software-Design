using NUnit.Framework;

namespace Task05;

public class Tests {
    [SetUp]
    public void Setup() {

    }

    [Test] 
    public void Test1() {
        Fraction empty = new();
        Assert.Pass();
    }

}