using static System.Console;
Clear();
WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
if (number % 2 == 0)
{
    WriteLine($"Число {number} четное");
}
else
{
    WriteLine($"Число {number} не четное");
}