// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[4];
int[] arrayR = new int[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-999999999, 999999999);
    arrayR[i]= array[i]*(-1);
}

Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", arrayR));





// int sumP = 0; // Сумма положительных эоементов
// int sumN = 0; // Сумма отрицательных

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next();

// if (array[i] > 0)
// {
//     array[i] = array[i]; // sumP = sumP +arrai[i];
// }
//     else // наш элемент массива отрицательный
//     {
//         sumN += array[i];//sumN = sumN + arrai[i]
//     }
// }

// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Сумма положительных чисел = {sumP}");
// Console.WriteLine($"Сумма отрицательных чисел = {sumN}");