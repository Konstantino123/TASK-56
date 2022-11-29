/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */
int m, n; 
 int value = 1; 
 Console.Write("Введите кол-во строк "); 
 m = Int32.Parse(Console.ReadLine()); 
 Console.Write("Введите кол-во столбцов "); 
 n = Int32.Parse(Console.ReadLine()); 
 Random rnd = new Random(); 
 int[,] numbs = new int[m, n]; 
 int row = rnd.Next(numbs.GetLength(0)+1); 
 int col = rnd.Next(numbs.GetLength(1)+1); 
 for (int i = 0; i<m; i++) 
 { 
 for (int j = 0; j < n; j++) 
 { 
 numbs[i, j] = value; 
 Console.Write(numbs[i, j] + " "); 
 value++; 
 } 
 Console.WriteLine(); 
 } 

void PrintUnivariateArray(int [] tempArray)
{
    Console.WriteLine($"Суммы элементов строк массива: {string.Join(", ", tempArray)}");
}

int[] StringsValue(int [,] tempArray)
{
    int[] result = new int[tempArray.GetLength(0)];
    int stringSum = new int();

    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            stringSum += tempArray[i, j]; 
        }
        result[i] = stringSum;
        stringSum = 0;
    }

    return result;
}

void MinStringNumber(int[] tempArray)
{
    int result = new int();
    int min = tempArray.Min();
    for (int i = 0; i < tempArray.Length; i++)
    {
        if(tempArray[i] == min) result = i + 1;
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
}


int[] stringsValue = StringsValue(tempArray: numbs);
PrintUnivariateArray(tempArray: stringsValue);
MinStringNumber(tempArray: stringsValue);