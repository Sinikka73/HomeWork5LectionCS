//  Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

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


int[] getNumbersOfaNewArray(int[] incomingArray, int count)
{
    int len = count /2;
    if(count%2 != 0)
    {
        len = count / 2 + 1;
    }

    int[] newArray = new int[len];
    
    for (int i = 0; i < len; i++)
    {
        
        newArray[i] = incomingArray[i]*incomingArray[count - i -1];
    }   
    return newArray;
}
Console.WriteLine();
Console.Write("Введите количество элементов в массиве: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] currentArray = getRandomArray(lenght, 1, 10);
printArray(currentArray);

Console.WriteLine();
int[] resultArray = getNumbersOfaNewArray(currentArray, lenght);
Console.WriteLine("Новый массив по условию задачи: ");
printArray(resultArray);