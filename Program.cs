// Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна 3 символа

//метод ввода массива строк с клавиатуры
string[] InputArray(int size)
{
    string[] ArrayIn = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} -й элемент массива: ");
        ArrayIn[i]  = Console.ReadLine();
    }
    return ArrayIn;
}

//метод вывода массива в консоль

void PrintArray(string[] ArrayPr)
{
    Console.Write("Исходный массив: [");
    for (int i = 0; i < ArrayPr.Length - 1; i++)
    {
        Console.Write("\"" + ArrayPr[i] + "\"" + ", ");
    }
    Console.Write("\"" + ArrayPr[ArrayPr.Length - 1] + "\"" + "]");
}

Console.Write("Введите количество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
string[] array = InputArray(count);
//Console.Write("Исходный массив: ");
PrintArray(array);

