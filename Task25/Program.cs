//Задача 25: Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Exponentiate (int a, int b)
{
    int exp = a;
    for (int i = 1; i < b; i++)
    {
        exp = exp * a;
    }
    Console.WriteLine($"{a}^{b} = {exp}");
}

Console.Write("Я хочу число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Возвести в степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

Exponentiate(number, degree);