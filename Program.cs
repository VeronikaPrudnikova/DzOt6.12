//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*

Console.Write("input a number: ");
string number = Console.ReadLine();

int length = number.Length;

if(length == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
    Console.Write($"{number} -> Да");
    }
    else 
    {
        Console.Write($"{number} -> Нет");
    }
}
else
{
    Console.Write($"{length} -> Не соотвествует!");
}
*/
// или 
/*
Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());


if(number >= 10000 && number < 100000)
{
    int division1 = number / 10000;
    int remainder1 = number % 10;
    Console.Write($"1: {division1} и {remainder1}\n");
    if(division1 == remainder1)
    {
        number = number / 10;
        int division2 = number / 100 % 10;
        int remainder2 = number % 10;
        Console.Write($"2: {division2} и {remainder2}\n");
        if(division2 == remainder2)
        {
            Console.Write($"{number} -> Да");
        }
    }
       else 
    {
        Console.Write($"{number} -> Нет");
    }
}
else
{
    Console.Write(" -> Не соотвествует!");
}

*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double lenght = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return Math.Round(lenght, 2);
}

Console.Write("input an x coordinate poit A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("input an y-coordinate poit A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("input an z-coordinate poit A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("input an x-coordinate poit B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("input an y-coordinate poit B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("input an z-coordinate poit B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distanBeetvinAB = Distance(xA, yA, zA, xB, yB, zB);

Console.Write($"Distance beetween point A and B is {distanBeetvinAB}");

*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*

Console.Write("Enter a number from 1 to N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"{N} -> ");

for (int index = 1; index <= N; index++)
{
    Console.Write($"{index*index*index},  ");
}

*/