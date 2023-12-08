// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Create2dArray(int row, int col, int min, int max)
{
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = new Random().Next(min, max + 1);
                }
            }
            return array;
        }
        
void Show2dArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

void MyArray(int[,] array, int collect){
    
    int sum = 0;
    int index = 0; int [] oneArray = new int[collect];
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            sum = sum + array[i,j];
        }
        oneArray[index] = sum;
        Console.WriteLine(oneArray[index]);
        sum = 0;
        index=index+1;
    }
 
    index = 0;
    int minsum = oneArray[0];
    int pos = 0;
    while (index < collect){
        if (oneArray[index]<minsum) {
            minsum = oneArray[index];
            pos = index;
        }
        index = index + 1;
    }

Console.WriteLine($"мин. сумма - {minsum}");  
Console.WriteLine($"номер строки с минимальной суммой элементов - {pos}");    
}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] created2dArray = Create2dArray(row, col, min, max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
MyArray(created2dArray, row);
