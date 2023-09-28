using Task05;

namespace FractionTest; 

public class FractionTest {

    [Test]
    public void Equals_TwoEqualsFraction_ReturnsTrue() {
        Fraction fraction1 = new(1, 2);
        Fraction fraction2 = new(1, 2);

        //bool actual = fraction1.Equals(fraction2);
        //Assert.That(actual, Is.True);
        
        Assert.That(fraction1.Equals(fraction2)); 
    }
}