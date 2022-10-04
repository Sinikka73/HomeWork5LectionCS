//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void fillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().NextDouble() + new Random().Next(-5, 50);
        index++;
    }
}

void printArray(double[] col)
{
    Console.Write ("[");
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write("{0:0.00}", col[position]);
        if(position < count - 1)
        {
            Console.Write("   ");
        }
        position++;
    }
    Console.Write ("]");
    Console.WriteLine();
}

double differenceMaxMinNumbers(double[] incomingArray)
{
    double maxNumber = incomingArray[0];
    double minNumber = incomingArray[0];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] < minNumber)
        {
            minNumber = incomingArray[i];
        }
        if(incomingArray[i] > maxNumber)
        {
            maxNumber = incomingArray[i];
        }
    }
    return maxNumber - minNumber;
}

Console.WriteLine();
Console.Write("Введите количество элементов в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[] array = new double[userNumber];
fillArray(array);
printArray(array);
Console.WriteLine();
double result = differenceMaxMinNumbers(array);
Console.Write("Разность между максимальным и минимальным элементами массива: {0:0.000}", result);