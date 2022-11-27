//Задача 25: Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A 
//в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16 

Console.WriteLine("Введите число А");
double A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

double Power(double a, int b)
{
    double result = 1;

    for (int i = 0; i < b; i++)
    {
        result *= a;  
    }
    return result;
}
double res = Power(A,B);
Console.WriteLine(res);
    