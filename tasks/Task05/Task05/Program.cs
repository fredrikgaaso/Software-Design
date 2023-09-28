using Task05;

Fraction empty = new( );
Fraction oneHalf = new(1, 2);
Fraction threeQuarter = new(3, 4);

Console.WriteLine($"Fraction is : {empty}");
Console.WriteLine($"Fraction is : {oneHalf}");
Console.WriteLine($"Fraction is : {threeQuarter}");

Fraction sum = oneHalf.Add(empty);
//Fraction sum = Fraction.Add(oneHalf, threeQuarter);
// Fraction sum = oneHalf + threeQuarter;
Console.WriteLine($"Sum is: {sum}");

