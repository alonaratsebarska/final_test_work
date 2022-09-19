/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина ккоторых меньше либо равна 3 символа.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
[“1234“, "1567", "-2", "computer science"] -> [“-2“]
["Denmark", "France", "Italy"] -> []
*/
int arraySize = Convert.ToInt32(InputInfo("Введите желаемое количество введённых Вами единиц информации:"));
 int[] array = new int[arraySize];
string InputInfo(string input)
{
    Console.Write(input);
    string output = Console.ReadLine();
    return output;

}
