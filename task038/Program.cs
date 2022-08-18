// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[6];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100);
}

Console.WriteLine(string.Join(", ", array));
int max = array [0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array [i])
    {
        max = array[i];
    }  
}
Console.WriteLine($"Max       -> {max}");

int min = array [0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array [i])
    {
        min = array[i];
    }  
}
Console.WriteLine($"Min       -> {min}");
Console.WriteLine($"Max - Min -> {max - min}");