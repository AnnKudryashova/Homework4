// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int[8];

var random = new Random();

for (int i = 0; i < 8; i++)
{
    array[i] = random.Next(1,100);
}

Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length-1)
    {
        Console.Write(array[i] + ",");
    }
    if (i == array.Length-1)
    {
        Console.Write(array[i] + "]");
    }
}