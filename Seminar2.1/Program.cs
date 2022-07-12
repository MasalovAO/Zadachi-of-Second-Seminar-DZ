//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, 
//то программа выводит остаток от деления.
Console.WriteLine("Введите первое число");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double number2 = Convert.ToInt32(Console.ReadLine());
string Search(double number1, double number2){
    if(number2%number1 == 0){
        
        return "Второе число кратное первому";
        
        //Console.WriteLine(chastnoe-"Первое число кратно второму числу");
        
    }
    else{
        
        return "Остаток " + number2%number1;

    }
}
Console.WriteLine(Search(number1,number2));
