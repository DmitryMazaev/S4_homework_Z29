/* Задача 29: Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int n = 8;
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,10);
}
Console.Write("[");
Console.Write(string.Join(", ", arr));
Console.Write("]");