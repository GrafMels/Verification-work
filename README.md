# Логика
Создавая программу я прописал три массива:
1. Исходный
2. Временный (в теле метода)
3. Результирующий

Исходный и временный имеют одинаковую длинну, но во временный записанны только строки менее четырёх символов, записываются они с индекса 0 и по порядку.

Результирующий массив берет свою длинну из переменной которую мы декрементируем каждый раз когда записываем что то новое во временую переменную. И берёт данные из временного массива. 

# Переменные и константы

1. arrayLength - длинна для исходного и временного массива
2. maxStringLength - константа [3] указывает масимальное колличество символов попадающих во
временный и результирующий массив.
3. arrayLengthResult - переменная для записи во временный массив и для определения длинны результирующего
4. i,j - временные переменные циклов

# Методы и циклы

## Методы

1. GetResultArray - Делает из исходного массива результирующий

2. PrintArray - метод печати массива

## Циклы

1. Цикл (строка 17) вне методов, для записи строк в каждый элемент массива

2. Первый цикл (строка 39) в методе GetResultArray служит для записи значений во временный массив

3. Второй цикл (строка 50) в методе GetResultArray служит для записи значений в результирующий массив

4. Цикл (строка 62) в методе PrintArray служит для вывода масиива

# Фишки

* Добавил goto для того что бы программа не давала вводить пользователю нулевые или отрицательные значения
* Хотел организовать еще goto из метода в программу, если бы строки менее трёх символов отсутсвовали. Реализовать не получилось. Просто создал условие что если строк меньше трёх символов нет то вам программа выдаст сообщение