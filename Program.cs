// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// *****************Задача 1**********************************
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Console.WriteLine("Введите число");
// int A=Convert.ToInt32(Console.ReadLine());

// int getsum()
// {
//     int sum=0;
//     for (int i = 0; i <= A; i++)
//     {
//         sum=sum+i;
//     }
//     return sum;
// }
// Console.WriteLine(getsum());

// *******************конец**********************
// ************Задача2************************
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());
// string num1=Convert.ToString(num);
// int size=num1.Length;
// Console.WriteLine(size);

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// int GetCount()
// {
//     int count = 0;
//     while (num>0)
//     {
//         count++;
//         num=num/10;
//     }
    
//     return count;
// }
// Console.WriteLine(GetCount());

// ****************конец**************
// ***************Задача 3*************
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// int Getnum()
// {
//     int result = 1;
//     for (int i = 2; i <=num; i++)
//     {
//         result=result*i;
//     }
    
//     return result;
// }
// Console.WriteLine(Getnum());

// ***********конец********************
// ************Задача 4************************************************************
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] Getarray()
// {
//     int [] array=new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]=new Random().Next(0,2);
//     }
//     return array;
// }

// Console.WriteLine(String.Join(",",Getarray()));

// ************конец*****************
// 
