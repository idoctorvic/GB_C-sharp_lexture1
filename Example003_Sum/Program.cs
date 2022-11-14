// int number1 = 3;
// int number2 = 5;
// Console.WriteLine(number1 + number2);
// the result can ba saved in a variable and only then printed
// int result = number1 + number2;
// Console.WriteLine(result);

int number1 = new Random().Next(1, 10);
Console.WriteLine(number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine(number2);
int result = number1 + number2;
Console.WriteLine(result);