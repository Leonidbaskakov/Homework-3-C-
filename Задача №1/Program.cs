//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int lastnum = number1 % 100;
int firstnum = number1 /1000;

if (firstnum == lastnum)
{
   Console.WriteLine("Число является полидромом");
}
else
Console.WriteLine("Число не является полидромом");