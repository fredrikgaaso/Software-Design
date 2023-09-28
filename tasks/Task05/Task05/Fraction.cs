namespace Task05; 

public class Fraction {

    public Fraction(int numerator = 0, int denominator = 1) {
        Numerator = numerator;
        Denominator = denominator;
        
        
    }
    private int Numerator { get; set; }
    private int Denominator { get; set; }

    public override string ToString() {
        return $"{Numerator}/{Denominator}";
    }

    public Fraction Add(Fraction other) {
        
        int newNumerator = Numerator * other.Denominator + Denominator * other.Numerator;
        int newDenominator = Denominator * other.Denominator;
        
        Fraction sum = new(newNumerator, newDenominator);
        return sum;

    }

}