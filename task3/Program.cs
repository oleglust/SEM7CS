// Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные
// и замените эти элементы на их квадраты.

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

void DOsqr(int[,] array)
{
    
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
         {
            if( i %2==0 && j%2==0)
            {
            int k = array[i,j];
            array[i,j] = k*k;
            }
        }
    }
   
       
    
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
//code
Console.WriteLine("введите 2 числа");
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows,columns,4,9);
PrintArray(array);
DOsqr(array);
Console.WriteLine(" ");
PrintArray(array);