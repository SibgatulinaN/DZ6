/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */
int ReadInt(string arg)
{
    System.Console.Write($"Введите числа: ");
    return int.Parse(Console.ReadLine());
}

int[] CreatArrey(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Введите {i + 1} элемент массива ");
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

    {
        Console.WriteLine($"a[ {i} ] = {array[i]}");
    }
}


int kol(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int Length = ReadInt("Введите количество элементов > 0");
int[] array;
array = CreatArrey(Length);
PrintArray(array);
//int array;


Console.WriteLine($"Чисел больше нуля: {kol(array)}");
//System.Console.WriteLine($"strung.Join(", ",{kol(array)}");