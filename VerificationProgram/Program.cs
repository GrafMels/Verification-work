// Задача: Написать программу, которая из имеющегося массива
// строк  формирует массив из строк, длинна которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.Write("Сколько строк вы хотите ввести: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

string[] array = new string[arrayLength]; 

for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"Введите {i+1}-ю строку: ");
    array[i] = Console.ReadLine();
}

string[] GetResultArray(string[] array, int arrayLength)
{
    string[] array2 = new string[arrayLength];

    int arrayLengthResult = 0;

    for (int i = 0; i < arrayLength; i++)
    {
        if(array[i].Length <= 3)
        {
            array2[arrayLengthResult] = array[i];
            arrayLengthResult++;
        }
    }

    string[] arrayResult = new string[arrayLengthResult];

    for (int i = 0; i < arrayLengthResult; i++)
    {
        arrayResult[i] = array2[i];
    }

    return arrayResult;
}

void PrintArray(string[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[ {array[i]} ]");
        Console.WriteLine();
    }
}
string[] arrayResult = GetResultArray(array, arrayLength);

PrintArray(arrayResult);