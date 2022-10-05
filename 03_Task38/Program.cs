// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

using static System.Console;
Clear();
WriteLine("Введите длину массива: ");
int a = int.Parse(ReadLine()!);

int[] array = getRandomArray(a);
printArray(array);
WriteLine($"Разница между максимальным и минимальным числом в массиве составляет {difMAxMin(array)}.");







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

int difMAxMin(int[] array4)
{
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < a; i++)
    {
       if(array[i] > max) max = array[i];
       if(array[i] < min) min = array[i];
    }
    int dif = max - min;
    return dif;
}
