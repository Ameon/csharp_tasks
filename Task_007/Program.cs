// Задача 7. Выполнить конкатенацию и интерполяцию.

// 1. Конкатенация
string name = "Дмитрий";
int age = 25;

string output = "Меня зовут " + name + " и мне " + age + " лет.";
Console.WriteLine(output);

// 2. Интерполяция
string name2 = "Дмитрий";
int age2 = 25;

string output2 = $"Меня зовут {name2} и мне {age2} лет.";
Console.WriteLine(output2);