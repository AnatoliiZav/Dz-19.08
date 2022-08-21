/*Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size]; //  создаем массив с именем "res" и размером "size"

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);   //обращаемся к элементу "i" в массиве  "res". К "maxValue" 
                                                              // прибавляем 1, тк это полуинтервал(используется значение -1), 
                                                              // и нужно, чтобы само значение участвовало.
    }
    return res;
}

int rev(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        int a = mas[i] % 2;
        if (a == 0)
        {
            sum++;
        }
    }
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = GetArray(N, 100, 999); // создаем массив, который обращается к вышесозданной функции и вводит данные
Console.WriteLine(String.Join(" ", array)); // передаем массив "array",  и перед ним, в " " вводим, через что будет выводиться результат, в данном случае через пробел.
Console.WriteLine($"{rev(array)}");
