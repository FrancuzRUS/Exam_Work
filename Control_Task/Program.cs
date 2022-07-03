
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых мнеьше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решениее не рекоменжуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами. 

Console.WriteLine("Введите количество элементов в массиве: ");
int k = int.Parse(Console.ReadLine());

string[] StringArray = new String[k];
int count = 0;

for (int i = 0; i < k; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    StringArray[i] = Console.ReadLine();
    if (StringArray[i].Length <= 3) ;
    count++;
}

string[] NewStringArray = new String[count];

int j = 0;
{
    for (int i = j; i < k; i++)
    {
        if (StringArray[i].Length <= 3)
        {
            NewStringArray[j] = StringArray[i];
            Console.Write($"{NewStringArray[j]}; ");
            j++;
        }
    }
}

