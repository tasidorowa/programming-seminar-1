// Написать программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго
// Переменная - именованная ячейка памяти

/*int first_var = 25;
int second_var = 5;

if (second_var * second_var == first_var)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}*/

// Написать программу, которая на вход принимает на вход число и выводит все целые числа от -N до N

/*int number = 5;
int neg_number = -number;

/*for (int i = -number; i<= number; i++)
{
    Console.Write(i);
    Console.Write(' ');
}

while (neg_number<=number)
{
    Console.Write(neg_number);
    Console.Write(' ');
    neg_number++;
}*/

// Написать программу, которая на вход принимает трехзначное число и выводит сумму 
//первой и последней цифры числа

int num = 123;
int first_digit = num / 100;
int last_digit = num % 10;
int sum = first_digit + last_digit;
Console.Write("Сумма первой и последне цифры = " + sum);

//System.Console.WriteLine