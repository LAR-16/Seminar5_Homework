﻿void InputArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] = new Random(). Next(100, 1000);
}

void ReleaseArray(int[] array)
{
    int count = 0;
    int m = 0;
    for(int i=0; i<array.Length; i++)
    {
        m = array[i] % 2;
        if( m == 0)
            count++;
    }
    Console.WriteLine($"Количество четных чисел = {count}");
    
}


Console.Clear();
Console.WriteLine("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ",array)}]");
ReleaseArray(array);
