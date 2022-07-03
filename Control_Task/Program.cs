// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых мнеьше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решениее не рекоменжуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами. 

string[] StringArray = new String[] { "GB", "HappyNewYear", "1", "222", "GeekBrain", "Exam" };
int count = 0; 

for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length < 3 );
        count++;
    }

string[] NewStringArray = new String[count]; 

for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= 3 ) NewStringArray[i] = StringArray[i];
        Console.Write($"{NewStringArray[i]} ");
    }


