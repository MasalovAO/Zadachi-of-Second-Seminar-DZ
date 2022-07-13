 //Напишите программу, которая выводит третью цифру 
 //заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

//метод который возвращает длину заданного числа 
 int getLength(int num) 
 { 
     int count = 0; 
     while (num != 0) 
     { 
         num = num / 10; 
         count++; 
     } 
     return count; 
 } 
  
 // метод в поиска и вывода третьей цифры 
 int findAndPrint3rdDigit(int num) 
 { 
     Console.Write("{0} -> ", num); 
  
     //проверяем длину заданного числа, если меньшe 3, то выводим сообщение 
     if (getLength(num) < 3) 
     { 
         Console.WriteLine("третьей цифры нет"); 
     } 
     else 
     { 
         int counter = getLength(num) - 3; 
         // Console.WriteLine(counter); 
         while (counter != 0) 
         { 
             num = num / 10; 
             counter--; 
         } 
  
         int thirdDigit = (num % 100) % 10; 
         Console.WriteLine(thirdDigit); 
     } 
    return num;
 } 
  
 Console.Write(findAndPrint3rdDigit(num)); 
 


        
        