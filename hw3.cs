﻿int a;
int b;
Console.WriteLine("Write the first number.");
a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the second number.");
b = Convert.ToInt32(Console.ReadLine());
int[] arr_a = {(a % 10), (a / 10)};
int[] arr_b = {(b % 10), (b / 10)};
int[] arr_c= {((a % 10) + (b % 10)), ((a / 10) + (b / 10))};
int c = (arr_c[1] * 10) + arr_c[0];
Console.WriteLine("Summ is "+ c);