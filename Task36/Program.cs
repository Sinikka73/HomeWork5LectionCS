// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void printArray(int[] incomingArray)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if(i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int getSumOfNumbersOnOddPos(int[] incomingArray)
{
    int sum = 0;
    for (int i = 1; i < incomingArray.Length; i+=2)
    {
        sum = sum + incomingArray[i];
    }
    return sum;
}
Console.WriteLine();
Console.Write("Введите количество элементов в массиве: ");
int lenght = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента массива: ");
int minPoint = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента в массиве: ");
int maxPoint = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(lenght, minPoint, maxPoint);
printArray(currentArray);

int result = getSumOfNumbersOnOddPos(currentArray);
Console.WriteLine();
Console.Write($"Сумма элементов в массиве, стоящих на нечетных позициях: {result}");