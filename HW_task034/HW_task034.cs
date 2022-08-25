// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateUserSizeArray()
{
    Console.Write("Введите количество элементов массива: ");
    int length = int.Parse(Console.ReadLine());
    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine("Элементы массива: " + String.Join(", ", Array));
    return Array;
}

int[] CreateRandomSizeArray()
{
    Console.Write("Введите максимальное количество элементов массива: ");
    int maxArrayLength = int.Parse(Console.ReadLine());
    int length = new Random().Next(1, maxArrayLength + 1);
    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(100, 1000);
    }
    
    Console.WriteLine($"Число элементов массива: " + (length));
    Console.WriteLine("Элементы массива: " + String.Join(", ", Array));
    return Array;
}

void CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
        Console.WriteLine($"Число четных элементов массива: " + (count));
}

Console.Clear();
Console.WriteLine("Если хотите задать размер массива самостоятельно - нажмите 1.");
Console.WriteLine("Если хотите задать размер массива случайным образом - нажмите 2.");
Console.WriteLine("Нажмите любое другое число, если хотите выйти");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        int[] UserArray = CreateUserSizeArray();
        CountEvenNumbers(UserArray); break;
    case 2:
        int[] RandomArray = CreateRandomSizeArray();
        CountEvenNumbers(RandomArray); break;
    default: Console.WriteLine("Всего доброго!"); break;
}