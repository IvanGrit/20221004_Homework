// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int a = int.Parse(ReadLine()!);

int[] array = getRandomArray(a);
printArray(array);
WriteLine($"Сумма нечётных чисел в сгенерированном массиве равна {sumOfNotEvenNumbers(array)}.");





int[] getRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
     result[i] = new Random().Next(1,100);
    
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

int sumOfNotEvenNumbers(int[] array4)
{
    int numbers = 0;
    for (int i = 0; i < a; i++)
    {
       if(array[i]%2 != 0) numbers += array[i];
        
    }
    return numbers;
}
