/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76  */

Console.WriteLine("Введите размер массива: ");        
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число1: ");        
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");        
int b = int.Parse(Console.ReadLine());


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size]; //  создаем массив с именем "res" и размером "size"

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * new Random().Next(minValue, maxValue + 1);   //обращаемся к элементу "i" в массиве  "res". К "maxValue" 
                                                              // прибавляем 1, тк это полуинтервал(используется значение -1), 
                                                              // и нужно, чтобы само значение участвовало.
    }
    return res;
}
double revlon(double[] mas)
{
    double maxValue = a;
    double minValue = b;
    double sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {   
        if (mas[i] < minValue)
        {
            minValue = mas[i];
        }
        
    }

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > maxValue)
        {
            maxValue = mas[i];
        }
        
    }
    
    sum = maxValue - minValue;
    return sum;
}


double[] array = GetArray(N, a, b); // создаем массив, который обращается к вышесозданной функции и вводит данные

Console.WriteLine(String.Join(" ",  array)); // передаем массив "array",  и перед ним, в " " вводим, через что будет выводиться результат, в данном случае через пробел.
Console.WriteLine($"Разница максимального и минимального значения = {revlon(array):N3}");