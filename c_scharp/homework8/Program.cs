//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of cols: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(minVal, maxVal + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArr = CreateRandom2dArray();
Show2dArray(myArr);

*/

/*
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void ShowMinSumRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"наименьшая сумма элементов равна {minRow}");
    Console.WriteLine($"{minSumRow + 1} строка имеет наименьшую сумму элементов");
}
ShowMinSumRow(myArr);
*/


/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] Product2Matrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    result[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    return result;
}
int[,] myArr2 = CreateRandom2dArray();
Show2dArray(myArr2);
Show2dArray(Product2Matrix(myArr, myArr2));
*/

/*
//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Create3dArray()
{
    Console.Write("Input numbers of z: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input min possible value: ");
    // int minVal = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input max possible value: ");
    // int maxVal = Convert.ToInt32(Console.ReadLine());
    int[,,] newArray = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                newArray[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return newArray;
}
void Show3dArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
int[,,] array3D = Create3dArray();
Show3dArray(array3D);
*/

/*
//Задача 62: Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 5
// 11 16 15 6
// 10 09 08 07

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

*/ 