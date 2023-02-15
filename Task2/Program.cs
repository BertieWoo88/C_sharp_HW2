// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
///645 -> 5
//78 -> третьей цифры нет

//32679 -> 6

//int num = new Random.()Next(100,1000);
void Poiskraz(int num)
{
    int iter = num/10;  //32679
    int n = 0;
    while(iter != 0)
    {
        n ++;
        iter = iter/10;  
    }
    if(n<2) Console.WriteLine("третьей цифры нет");
    else
    {
        while (n>2)
        {
            num = num/10;
            n=n-1;
        }
    Console.WriteLine(num%10);
    }
}
Console.Write("введите число :");
int num = int.Parse(Console.ReadLine()!);
Poiskraz(num);
//int raz = Poiskraz(num);
//Console.WriteLine($"разряд:{raz}");




