// 2м массив мхн.
// каждый элемент массива находится по формуле: amn=m+n

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = i+j;
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // вывод массива
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

int[,] array = GetArray(rows,columns);
PrintArray(array);
