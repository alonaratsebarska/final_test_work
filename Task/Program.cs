/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина ккоторых меньше либо равна 3 символа.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
[“1234“, "1567", "-2", "computer science"] -> [“-2“]
["Denmark", "France", "Italy"] -> []
*/
int arraySize = Convert.ToInt32(InputInfo("Введите желаемое количество введённых Вами единиц информации:"));

string[] array = new string[arraySize];
FillArray(array);

Console.WriteLine($"\n Введённая Вами информация в формате массива: ");
PrintArray(array);
Console.WriteLine($"\n Отсортированный массив: ");
Console.Write("[");
PrintSortedArray(array);
Console.Write("]");

string InputInfo(string input)
{
    Console.Write(input);
    string output = Console.ReadLine();
    return output;

}

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = InputInfo("Введите любое значение (слово, цифру, знак и тд.): ");
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}\t");
        else if (i > 0 && i < arr.Length - 1) Console.Write($"{array[i]}\t");
        else Console.Write($"{array[i]}]");
    }
}

void PrintSortedArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length < 3) Console.Write($"{array[i]}\t");
        if (array[i].Length == 3) Console.Write($"{array[i]}");
    }
}
