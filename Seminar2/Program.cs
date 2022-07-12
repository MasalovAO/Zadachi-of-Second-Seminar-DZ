//Напишите программу, 
//которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int ShowNumber(){
    int num = new Random().Next(100,999);
    Console.Write(num+"->");
    int first = num/100;
    Console.Write(first);
    int deleteSecond = num%100;
    int third = deleteSecond%10;
    return third;
}
Console.WriteLine(ShowNumber());