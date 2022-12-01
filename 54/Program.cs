// Задайте двумерный массив.
//  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("input number rows");
int rows= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number columns");
int columns= Convert.ToInt32(Console.ReadLine());

int[,] array= new int[rows,columns];

for(int i = 0; i < rows  ; i++)
{
    for(int j = 0; j <columns  ; j++)
    {
        array[i,j] = new Random().Next(0,10);

        Console.Write(array[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int i = 0; i < rows  ; i++)
{
    for(int j = 0; j <columns  ; j++)

    {
        for (int k = j + 1; k <columns; k++)
        {

            if (array[i,k] > array[i,j])
                {
                    int tmp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = tmp;
                }
                
        }        
        Console.Write(array[i,j]+"\t");    
    }
    Console.WriteLine();
}