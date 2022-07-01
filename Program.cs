/* Решение задачи 10

int CutNumber()
{
    int num = new Random().Next(100,1000);

    Console.WriteLine("текущее случайное число: " + num);

    int a = num / 10;
    int b = a % 10;

    int result = b;
    return result; 
}


int number = CutNumber();
Console.WriteLine("результат: " + number); */

/* Решение задачи 13

int three()
{
    int a;
    int num = new Random().Next(1,1000000);

    Console.WriteLine("текущее случайное число: " + num);
    a = num;
if (num<100)
{
   
   Console.WriteLine(num + " - выбранное число не имеет третьего разряда");
}
else
    for (; num >= 100;)
    {
        a = num % 10;    
        num = num / 10;
    }
    return a; 
}

int number = three();
Console.WriteLine("результат: " + number); */


/* Решение задачи 15
void day(int a)
{
    if (a>=1 && a<=7)
    {
        if (a>=1 && a<=5)
        {
        Console.WriteLine(a + " - этот день не является выходным");
        }
        else
        {
        Console.WriteLine(a + " - ура, выходной!");
        }
    }
    else
        {
        Console.WriteLine(a + " - указанное число выходит из диапазона от 1 до 7 и не является днем недели!");
        }
}


Console.WriteLine("Введите число от 1 до 7, обозначающее день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

day(a);
    */