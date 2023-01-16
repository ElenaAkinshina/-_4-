/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B. 
 (Задачи, решенные через Math.Pow, будут отправлены на переделку, 
 так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

/*Console.Write("Введи число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($" {A}, {B} -> {GetS(B)}");

int GetS(int B){
    int res = 1;
    for(int i = 1; i <= B; i++){
        res = res*A; 
    }
    return res;
}*/


/*Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

/*Console.WriteLine("Введите число: ");
int S = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр {S} равно {CountSum(S)}");

//метод//

int CountSum(int num){
    int sum = 0;
    if (num == 0) return 0;
    while (num > 0){
        
        sum = sum + num % 10;
        num = num / 10;
            }
    return sum;
}*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)


int[] myArray = GetArray(8);
Console.WriteLine($"[{String.Join(",", myArray)}]");

//метод//
int[] GetArray(int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(9);
     }
     return myArray;
}