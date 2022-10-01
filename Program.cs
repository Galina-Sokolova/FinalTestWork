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
    if (ArrayPr.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < ArrayPr.Length - 1; i++)
        {
            Console.Write("\"" + ArrayPr[i] + "\"" + ", ");
        }
        Console.Write("\"" + ArrayPr[ArrayPr.Length - 1] + "\"" + "]");
    }
    else
    {
        Console.Write("[]");
    }
}

// Создание массива из 1 - 3-х символьных элементов

string[] CreationArray(string[] ArrayCr)
{
    int currentSize = 0;
    string[] arrayFinal = new string[currentSize];
    int j = 0;
    for (int i = 0; i < ArrayCr.Length; i++)
    {
        if (ArrayCr[i].Length <= 3)
        {
            currentSize++;
            Array.Resize(ref arrayFinal, currentSize);
            arrayFinal[j] = ArrayCr[i];
            j++;
        }

    }
    return arrayFinal;
}

int count;
do
{
    Console.Write("Введите количество элементов в массиве: ");
    count = Convert.ToInt32(Console.ReadLine());
    if (count <= 0)
    {
      Console.WriteLine("Необходимо ввести натуральное число");
    } 
}
while (count <= 0);

string[] arraySource = InputArray(count);
Console.WriteLine("Исходный массив: ");
PrintArray(arraySource);
Console.WriteLine();
Console.WriteLine();
string[] arrayNew = CreationArray(arraySource);
Console.WriteLine("Итоговый массив: ");
PrintArray(arrayNew);
