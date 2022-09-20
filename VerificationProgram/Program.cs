// Задача: Написать программу, которая из имеющегося массива
// строк  формирует массив из строк, длинна которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.Write("Сколько строк вы хотите ввести: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

if (arrayLength <= 0) goto End;

string?[] array = new string[arrayLength];

const int maxStringLength = 3;

for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"Введите {i + 1}-ю строку: ");
    array[i] = Console.ReadLine();
}


// Метод с двумя циклами:


// В первом записываем в новый массив такой же длинны все 
// строки с 3 и меньше символами и считаем их колличество.

// Во втором записываем всё в результирующий массив нужной 
// длинны благодаря первому колличеству в первом цикле.

string?[] GetResultArray(string?[] array, int arrayLength, int maxStringLength)
{
    string?[] array2 = new string?[arrayLength];

    int arrayLengthResult = 0;

    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i]?.Length <= maxStringLength)
        {
            array2[arrayLengthResult] = array[i];
            arrayLengthResult++;
        }
    }

    string?[] arrayResult = new string[arrayLengthResult];

    for (int i = 0; i < arrayLengthResult; i++)
    {
        arrayResult[i] = array2[i];
    }

    return arrayResult;
}

// Метод печати массива
void PrintArray(string?[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[ {array[i]} ]");
        Console.WriteLine();
    }
}
string?[] arrayResult = GetResultArray(array, arrayLength, maxStringLength);

PrintArray(arrayResult);

//Если в массиве не строк равных 3 или менее
if (arrayResult.Length == 0)
{
    Console.WriteLine();
    Console.WriteLine("Нет строк, с колличеством символов 3 или менее");
}

// Вывод ввода нулевого или отрицательного значения
End: if (arrayLength <= 0)
{
    Console.WriteLine();
    Console.WriteLine("Колличество строк не может равнятся нулю или менее.");
}



