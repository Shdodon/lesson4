// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine();

int result = Qrt(UserAdd(), UserAdd());
Console.WriteLine(result);
// Qrt    тут выдает степень
//Qrt(num1, num1);

int UserAdd()
{
    //int count = 1;
    //while (count <= 2)
    //{
    Console.WriteLine($"Введите число, нажмите Enter:");
    int number = int.Parse(Console.ReadLine());
    //count++;
    //}
    return (number);
}
int Qrt(int first, int second)
{
    //Для быстрой проверки работы метода
    int temp = 1;
    // int second = 5; // быстрая проверка
    // int first = 3; 
    int degree = 1;

    while (temp <= second)
    {
        degree = degree * first;
        //Console.WriteLine(degree); проверка возведения в степень
        temp++;
    }
    return (degree);
}

//Прим. т.к. задание самопроверка:( сэкономили время на оформлении 

