System.Console.WriteLine("Введите число ");
string text = Console.ReadLine();
int number = int.Parse(text);

if (number % 2 == 0)
{
    System.Console.WriteLine($"Да, {number} - чётное число");
}
else
{
    System.Console.WriteLine($"Нет, {number} - нечётное число");
}