// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number1 )
{
    Console.WriteLine($"{count} | {Math.Pow(count, 3)}");
    count++;
}
