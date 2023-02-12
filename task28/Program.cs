// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] numbers = new int[8];

//Console.WriteLine(numbers.Length);
void NewArray(int[] array, int min, int max)
{
    int length = array.Length;
    int count = 0;
    while (count < length)
    {
        array[count] = new Random().Next(min, max);
        //onsole.WriteLine(array[count]);
        count++;
    }
}

void PrintArray(int[] printer)
{
    int counter = printer.Length;
    int index = 0;
    while (index < counter)
    {
        Console.Write($"{printer[index]} ");
        index++;
    }
}

NewArray(numbers, 1, 10);
PrintArray(numbers);