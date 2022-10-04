// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void fillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void printArray(int[] col)
{
    Console.Write ("[");
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        if(position < count - 1)
        {
            Console.Write(", ");
        }
        position++;
    }
    Console.Write ("]");
    Console.WriteLine();
}

int countOfEvenNumbers(int[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        int digit = incomingArray[i] %2;
        if(digit == 0)
        {
            count = count +1;
        }
    }
    return count;
}

Console.WriteLine();
Console.Write("Введите количество элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[userNumber];
fillArray(array);
printArray(array);
Console.WriteLine();
int result = countOfEvenNumbers(array);
Console.Write($"Количество чётных чисел в массиве: {result}");