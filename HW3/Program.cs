// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void PrintArray(double[,] inArray,int columns)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        
        Console.WriteLine();
    }
    SearchAR(inArray,columns);
}

void SearchAR(double[,] inArray2,int rows) //ищем среднее арифметическое 
{
    for (int j = 0; j < inArray2.GetLength(0); j++)
    {
        double AR = 0;
        for (int i = 0; i < inArray2.GetLength(1); i++)
        {
        
           AR=AR+inArray2[i,j];
          
        }
        Console.Write($"{AR/rows} ");

    }
}
//code



Console.WriteLine("введите 2 числа ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(rows,columns,0,10);
PrintArray(array,columns);


