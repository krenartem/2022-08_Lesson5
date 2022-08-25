// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateUserSizeArray(int min, int max)
{
    Console.Write("Введите количество элементов массива: ");
    int[] Array = new int[int.Parse(Console.ReadLine())];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Элементы массива: " + String.Join(", ", Array));
    return Array;
}

int[] CreateRandomSizeArray(int min, int max)
{
    Console.Write("Введите максимальное количество элементов массива: ");
    int maxArrayLength = int.Parse(Console.ReadLine());
    int[] Array = new int[new Random().Next(1, maxArrayLength + 1)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine($"Число элементов массива: " + (Array.Length));
    Console.WriteLine("Элементы массива: " + String.Join(", ", Array));
    return Array;
}

void SumOddIndexNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов массива с нечетными индексами: " + (sum));
}

Console.Clear();
Console.Write("Введите минимальное значение в массиве: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение в массиве: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Если хотите задать размер массива самостоятельно - нажмите 1.");
Console.WriteLine("Если хотите задать размер массива случайным образом - нажмите 2.");
Console.WriteLine("Нажмите любое другое число, если хотите выйти");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        int[] UserArray = CreateUserSizeArray(arrayMin, arrayMax);
        SumOddIndexNumbers(UserArray); break;
    case 2:
        int[] RandomArray = CreateRandomSizeArray(arrayMin, arrayMax);
        SumOddIndexNumbers(RandomArray); break;
    default: Console.WriteLine("Всего доброго!"); break;
}