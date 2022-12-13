void InputArray (int[] array)
{
    for( int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

void OddNumbers(int[] array)
{
    int m = 0;
    for( int i = 0; i < array.Length; i++)
    {
        m = array[i] % 2;
        if (m != 0)
            Console.Write($"{array[i]} ");
        
    }       
}

void EvenNumbers(int[] array)
{
    int m = 0;
    for( int i = 0; i < array.Length; i++)
    {
        m = array[i] % 2;
        if (m == 0)
            Console.Write($"{array[i]} ");
    }       
}

void Comparing(int[] array)
{
   int odd = 0;
   int even = 0;
   int m = 0;
    for( int i = 0; i < array.Length; i++)
    {
        m = array[i] % 2;
        if (m == 0)
            even = even + 1;
        else
            odd = odd + 1;
    } 
    if (even > odd)
        Console.WriteLine("yes");
    else 
        Console.WriteLine("no"); 
}
     
Console.Clear();
int n = new Random(). Next(1, 101);
Console.WriteLine(n);
int[] array = new int [n];
InputArray(array);
Console.WriteLine($"[{string.Join(" ", array)}]");
Console.WriteLine();
OddNumbers(array);
Console.WriteLine();
EvenNumbers(array);
Console.WriteLine();
Comparing(array);
