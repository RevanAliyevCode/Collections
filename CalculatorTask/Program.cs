using static System.Console;
using CalculatorTask;

bool exit = false;

do
{

    string[] opt = { "+", "-", "*", "/" };
returnThere:
    Write("Please enter operation (3 + 3): ");
    string[] userInput = ReadLine().Split(' ');

    if (userInput.Length != 3 || !opt.Contains(userInput[1]))
        goto returnThere;

    if (double.Parse(userInput[2]) == 0 && userInput[1] == "/")
    {
        WriteLine("Can not divide 0");
        goto returnThere;
    }

    Calculator<double> calc = new(double.Parse(userInput[0]), double.Parse(userInput[2]));

    switch (userInput[1])
    {
        case "+":
            calc.Sum();
            break;
        case "-":
            calc.Substract();
            break;
        case "*":
            calc.Multible();
            break;
        case "/":
            calc.Divide();
            break;
        default:
            WriteLine("There is not operator like that");
            break;
    }

    Write("Do you want to continute (y/n): ");
    exit = ReadLine() == "y" ? false : true;

} while (!exit);
