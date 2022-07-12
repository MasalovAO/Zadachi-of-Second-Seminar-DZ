//Напишите программу, 
//которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string Cheaker(int num)
{
    if(num%7 + num%23==0)
    {
        
        return"Ваше число кратно 7 и 23";

    }
    else
    {
        return"Ваше число не кратно";
    }

}

Console.WriteLine(Cheaker(num));