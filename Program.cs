//Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна 3 
//символа. Первоначальный масиив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

//Примеры 
//["hello", "2", "world", ":-)"]->["2", ":-)"]
//["1234", "1567", "-2"]-> ["-2"]

Console.Clear();
string[] array = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array.Length];
void ArrayCheck(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayCheck(array, array2);
PrintArray(array);
PrintArray(array2);
