// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void MyArray(int[,] array, int rowIndex, int colIndex){
    int min = array[0,0];
    int result = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if (i==rowIndex && j==colIndex){
                result = (array[i,j]);
            }   
        }
    }
    if (result == 0){
        Console.WriteLine("такого элемента нет");
        }
    else {
        Console.WriteLine(result);
        }
    
}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter rowIndex value: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter colIndex value: ");
int colIndex = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
MyArray(created2dArray, rowIndex, colIndex);

