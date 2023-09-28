using System.Xml.Xsl;

namespace Task05; 

public class Fraction {
    public bool Equals(Fraction other) {
        return Numerator * other.Denominator == Denominator * other.Numerator;
    }
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

    public static Fraction Add(Fraction left, Fraction right) {
        int newNumerator = left.Numerator * left.Denominator + right.Denominator * right.Numerator;
        int newDenominator = left.Denominator * right.Denominator;
        
        Fraction sum = new(newNumerator, newDenominator);
        return sum;    
    }

}