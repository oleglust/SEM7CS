// Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] GetArray(int m, int n, int min , int max)
{
    int[,] result = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max);
        }
    }
    return result;
}

int DOsqr(int[,] array, int sum)
{
    
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
         {
            if( i == j)
            {
            sum = sum + array[i,j];
            
            }
        }
    }  
    printSUM(sum);
    return sum;
}
void PrintArray(int[,] inArray)
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
void printSUM(int sum)
{
   
        Console.WriteLine(sum);
    
}

//code
Console.WriteLine("введите 2 числа");
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows,columns,4,9);
PrintArray(array);
DOsqr(array, 0);
//printSUM(sum);
