// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int a = int.Parse(ReadLine()!);

int[] array = getRandomArray(a);
printArray(array);
WriteLine($"Количество чётных чисел в сгенерированном массиве равно {evenNumbers(array)}.");





int[] getRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
     result[i] = new Random().Next(100,1000);
    
    }
    return result;
}

void printArray(int[] array3)
{
    string FinalString = "[ ";
    foreach (int item in array3)
    {
        FinalString+=$"{item} ";
    }
    FinalString += "]";
    WriteLine(FinalString);
}

int evenNumbers(int[] array4)
{
    int numbers = 0;
    for (int i = 0; i < a; i++)
    {
       if(array[i]%2 == 0) numbers++;
        
    }
    return numbers;
}