// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


double[,] GetArray(int m, int n, int min , int max)
{
    double[,] result = new double[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = Convert.ToDouble(new Random().Next(0, 9));
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Searchnum(double[,] inArray2, int rows, int columns)
{
    if( rows > inArray2.GetLength(0) || columns>inArray2.GetLength(1)) Console.WriteLine("Такого значения нет((");
    else Console.WriteLine(inArray2[rows-1,columns-1]);
}
//code


double[,] array = GetArray(10,10,0,10);
PrintArray(array);

Console.WriteLine("введите 2 числа ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

Searchnum(array,rows,columns);