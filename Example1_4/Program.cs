using static System.Console;
Clear();
WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(ReadLine());
int number2 = Convert.ToInt32(ReadLine());
int number3 = Convert.ToInt32(ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
WriteLine($"Максимальное из трех чисел {max}");