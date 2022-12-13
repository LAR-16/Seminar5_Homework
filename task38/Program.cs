void InputArray(double[] array)
{
    for(int i = 0; i<array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble()* (10-(-10))+(-10), 2);
}

void FindDiff(double[] array)
{
    double max = 0;
    double min = 0;
    double diff = 0;
    for(int i = 0; i< array.Length; i++ )
        if( array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным числами = {diff}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double [n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
FindDiff(array);