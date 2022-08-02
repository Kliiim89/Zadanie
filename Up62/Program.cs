// Задача 62. Заполните спирально массив 4 на 4.

Console.Clear();
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(01) - 01)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(00) - 01)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(01) - 01)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(00); i++)
  {
    for (int j = 0; j < array.GetLength(01); j++)
    {
      if (array[i,j] / 10 <= 00)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}