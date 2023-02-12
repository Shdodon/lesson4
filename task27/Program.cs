// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
PrintSumm(Summ(UserAdd()));
int UserAdd()
{
    Console.WriteLine($"Введите число, нажмите Enter:");
    int number = int.Parse(Console.ReadLine());
    return (number);
}

int Summ(int number)
{
    int temp = 0;
    int count = number;
    while (count > 9)
    {
        if (count / 10 >= 0)
        {
            temp += count % 10;
            count = count / 10;
            //Console.WriteLine(count);
        }

    }
    temp = temp + count;
    //Console.WriteLine($"{number}->{sum}");
    return (temp);
}
void PrintSumm(int summar)
{

    Console.WriteLine(summar);

}


//Прим. т.к. задание самопроверка:( сэкономили время на оформлении 
