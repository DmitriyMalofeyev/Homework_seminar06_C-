//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Укажите какое количество чисел вы собираетесь ввести "); 
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int count = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число " + (i + 1));
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество введенных чисел больше нуля: " + count); 