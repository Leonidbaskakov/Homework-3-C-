//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите x координаты первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y координаты первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z координаты первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x координаты второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y координаты второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z координаты второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Pifagor (int xc1, int xc2, int yc1, int yc2, int zc1, int zc2 )
{
     return Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2-yc1)*(yc2-yc1) + (zc2-zc1) * (zc2-zc1));
}

double result = Pifagor (x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между точками {Math.Round(result, 2)}");