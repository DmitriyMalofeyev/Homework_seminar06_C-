//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите через пробел любое количество чисел: "); 
string? input = Console.ReadLine();
int[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
int count = 0;

foreach (var i in data)
{
    if (i > 0)
    {
        count++;
    } 
}

Console.WriteLine("Количество введенных чисел больше нуля: " + count); 