// Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна 3 символа

//метод ввода массива строк с клавиатуры
string[] InputArray(int size)
{
    string[] Array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} -й элемент массива");
        Array[i]  = Console.ReadLine();
    }
    return Array;
}
