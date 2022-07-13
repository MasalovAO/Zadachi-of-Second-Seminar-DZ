//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
    
while (num < 8 && num > 0){
        
     if(num <= 5 && num > 0){

        Console.WriteLine(num+ "<=> Будний день");
        break;
        }
        else{
         Console.WriteLine(num+ "<=> Выходной день");
        break;
        }

}
   
