void InputArray (int[] array)
{
    for(int i =0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

void ReleaseArray (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i=i+2)
        sum = sum + array[i];
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
}


Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
