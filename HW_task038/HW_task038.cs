// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateUserSizeArray(double max)
{
    Console.Write("Введите количество элементов массива: ");
    double[] Array = new double[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().NextDouble() * max;
    }
    Console.WriteLine("Элементы массива: " + String.Join(" | ", Array));
    return Array;
}

double[] CreateRandomSizeArray(double max)
{
    Console.Write("Введите максимальное количество элементов массива: ");
    int maxArrayLength = int.Parse(Console.ReadLine());
    double[] Array = new double[new Random().Next(1, maxArrayLength + 1)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().NextDouble() * max;
    } Console.WriteLine($"Число элементов массива: " + (Array.Length));
    Console.WriteLine("Элементы массива: " + String.Join(" | ", Array));
    return Array;
}

void DifferenceMinMax(double[] array)
{
    double min = 0;
    double max = 0;
    if (array[0] > array[1])
    {
        max = array[0];
        min = array[1];
    }
    else
    {
        max = array[1];
        min = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    }
    Console.WriteLine($"Max = " + (max));
    Console.WriteLine($"Min = " + (min));
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = " + (max - min));
}

Console.Clear();
Console.Write("Введите максимальное значение в массиве: ");
double arrayMax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Если хотите задать размер массива самостоятельно - нажмите 1.");
Console.WriteLine("Если хотите задать размер массива случайным образом - нажмите 2.");
Console.Write("Нажмите любое другое число, если хотите выйти: ");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        double[] UserArray = CreateUserSizeArray(arrayMax);
        DifferenceMinMax(UserArray); break;
    case 2:
        double[] RandomArray = CreateRandomSizeArray(arrayMax);
        DifferenceMinMax(RandomArray); break;
    default: Console.WriteLine("Всего доброго!"); break;
}