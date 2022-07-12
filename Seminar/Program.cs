int ShowNumber(){
    int num = new Random().Next(10,99);
    int first = num/10;
    int second = num%10;

    Console.Write(num+"->");

    if(first>second)
    {
        return first;
    }    

    else
    {
        return second;
    }    
    
    
}
Console.WriteLine(ShowNumber());