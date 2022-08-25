// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] miniArray(int N, int start, int end)
{
    int[] newArray = new int[N];
    
    for (int i = 0; i < N; i++)
    {
        newArray[i] = new Random().Next(start, end);
    } 
     return newArray;
}

int[] array = miniArray(15, 100, 999);
int count = 0;

for (int a = 0; a < array.Length; a++)
{
    if (array[a] % 2 == 0) count++; 
}
Console.WriteLine($"Массив: [{String.Join(" | ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве: {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] maxiArray(int N, int start, int end) // копия из 1 задачи. Создание рандомного массива
{
    int[] newArray = new int[N];

    for (int i = 0; i < N; i++)
    {
        newArray[i] = new Random().Next(start, end);
    } 
     return newArray;
}

int[] arrayB = maxiArray(4, int.MinValue / 2, int.MaxValue / 2); // диапазон урезан в 2 раза, т.к. если сумма превысит порог int, она будет неверно возвращаться.
int sum = 0;

for (int b = 0; b < arrayB.Length; b++)
{
    {
        if (b % 2 != 0) sum += arrayB[b]; // Четные индексы: 0, 2, 4. Нечетные: 1, 3, 5 и т д.
    }
}
    Console.WriteLine($"Массив: [{String.Join(" | ", arrayB)}]");
    Console.WriteLine($"сумма значений нечетных индексов: {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3 7 22 2 78] -> 76

double[] pureArray(int N)
{
    Random random = new Random();
    double[] oldArray = new double[N];

    for (int i = 0; i < N; i++)
    {
        oldArray[i] = random.NextDouble();
    }
    return oldArray;
}

double [] arrayC = pureArray(5);
double min = arrayC[0];
double max = arrayC[0];

for (int c = 0; c < arrayC.Length; c++)
{
    {
        if (arrayC[c] < min) min = arrayC[c];
        if (arrayC[c] > max) max = arrayC[c];
    }
}
    Console.WriteLine($"Массив: [{String.Join(" | ", arrayC)}]");
    Console.WriteLine($"Максимальный элемент: {max}, минимальный элемент {min}, разница {max - min}");
