//Напишите программу, которая принимает
//на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
string Cheaker(int num1, int num2)
{
    if( num2%num1 == 0 && num1%num2 != 0 )
    {
        return "Второе число является квадратом первого числа";
    }
    else
    {
        return "Первое число является квадратом второго числа";
    }

}
Console.WriteLine(Cheaker(num1,num2));