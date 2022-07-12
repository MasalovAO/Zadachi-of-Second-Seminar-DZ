//Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int ShowSecNum(){

    int first2 = num%100;
    int Sec = first2/10;
    Console.Write(num+"->");
    return Sec;

}
Console.WriteLine(ShowSecNum());