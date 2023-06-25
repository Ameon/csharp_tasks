// Задача 8. Взять число и возвести его в квадрат.
Console.Write("Введите число, квадрат которого вы хотите увидеть -> ");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num * num;
System.Console.WriteLine($"Квадрат числа {num} -> {quad}");