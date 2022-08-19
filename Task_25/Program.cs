// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Degree(int A, int B){
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result*A;
    }
    return result;
}

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B");
int B = int.Parse(Console.ReadLine());

if (B <= 0)
{
    Console.WriteLine("Введено неверное число");
    return;
}
int result = Degree(A, B);
Console.WriteLine(result);