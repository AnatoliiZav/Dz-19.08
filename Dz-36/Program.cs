/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0  */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size]; //  создаем массив с именем "res" и размером "size"

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);   //обращаемся к элементу "i" в массиве  "res". К "maxValue" 
                                                              // прибавляем 1, тк это полуинтервал(используется значение -1), 
                                                              // и нужно, чтобы само значение участвовало.
    }
    return res;
}

int rev(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i = i + 2)
    {
        sum = mas[i] + sum;

    }
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());

int[] array = GetArray(N, min, max); // создаем массив, который обращается к вышесозданной функции и вводит данные
Console.WriteLine(String.Join(" ", array)); // передаем массив "array",  и перед ним, в " " вводим, через что будет выводиться результат, в данном случае через пробел.
Console.WriteLine($"{rev(array)}");