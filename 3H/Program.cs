// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i,j] =new Random().Next(0,21);
    Console.Write(matrix[i,j]+" ");
    }
Console.WriteLine();
}
Console.WriteLine("____________");

Console.WriteLine("Введите координату строки ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату столбца ");
int m = Convert.ToInt32(Console.ReadLine());

if (n>rows && m>columns)
{
    Console.WriteLine("такого числа не существует в заданном массиве");
}

else
{   
    
    object c = matrix.GetValue(n,m);
    Console.WriteLine("искомое вами число в массиве - "+c);
}

