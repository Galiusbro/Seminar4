//Задача 27: Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе.

void Sum (int number)
{
    if (number < 0)
    {
        number = -number;
    }
    int sum = 0;
    while (number > 0)
    {
    sum = sum + (number % 10);
    number /= 10;
    }
    Console.WriteLine(sum);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Sum(num);