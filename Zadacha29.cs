/* Задача 29: Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

void arrayOne(int [] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1,10);
    }
}
void printArray (int [] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($" {a[i]} ");
    }
    Console.Write("]");
}
int[] array = new int[8];
arrayOne(array);
printArray(array);