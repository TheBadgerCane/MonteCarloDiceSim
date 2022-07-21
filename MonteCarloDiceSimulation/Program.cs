using MonteCarloDiceSimulation;

Calculations calc = new Calculations();

Console.WriteLine("Monte Carlo simulation of rolling dice.");

Console.WriteLine("Chose how much sides the dice has:");
var sidesAsString = Console.ReadLine();
int inputSides;
while (!int.TryParse(sidesAsString, out inputSides) || inputSides < 2)
{
    Console.WriteLine("This is not an integer number!");
    sidesAsString = Console.ReadLine();
}
calc.DiceSides = inputSides;

Console.WriteLine("Chose how much dice are being rolled:");
var diceAsString = Console.ReadLine();
int inputDice;
while (!int.TryParse(diceAsString, out inputDice) || inputDice < 1)
{
    Console.WriteLine("This is not an integer number!");
    diceAsString = Console.ReadLine();
}
calc.DiceCount = inputDice;

Console.WriteLine("Chose how much iterations the simulation will perform:");
var iterationsAsString = Console.ReadLine();
int inputIterations;
while (!int.TryParse(iterationsAsString, out inputIterations) || inputIterations < 1)
{
    Console.WriteLine("This is not an integer number!");
    iterationsAsString = Console.ReadLine();
}
calc.SimIterations = inputIterations;


Console.WriteLine("Save result to file? [Y/N]");
var input = Console.ReadKey();
if (input.Key == ConsoleKey.Y)
{
    calc.IsSaveResult = true;
    Console.WriteLine();
    Console.WriteLine("Saving.");
}
else
{
    calc.IsSaveResult = false;
    Console.WriteLine();
    Console.WriteLine("Will not save result");
}

float result = calc.CalculateResult();
Console.WriteLine("Average of rolling a " + calc.DiceSides + "-sided die " + calc.DiceCount + " times and picking the highest is: " + result + ".");