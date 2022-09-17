using static System.Console;
Clear();
WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(ReadLine());
int number2 = Convert.ToInt32(ReadLine());
if (number1 > number2)
{
    WriteLine($"Максимальное из чисел {number1}");
}
else
{
    WriteLine($"Максимальное из чисел {number2}");
}