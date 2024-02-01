// task1

// void Integers(int m, int n)
// {
//     if (m <= n)
//     {
//         System.Console.Write(m + " ");
//         Integers(m + 1, n);
//     }
// }

// System.Console.Write("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Integers(m, n);

// task2

// int ArckFunc (int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     if (m == 0)
//         return ArckFunc(n - 1, 1);
//     else 
//         return ArckFunc(n - 1, ArckFunc(n,m - 1));
// }

// System.Console.Write("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(ArckFunc(n,m));

//в презентации есть маленькая ошибка. в примере к дз2 А(2,3) = 9, а не 29 (местами перепутали m и n).

// task3

int[] CreateArray(int[] array, int min, int max, int index)
{
    if (index < array.Length)
    {
        array[index] = new Random().Next(min, max + 1);
        System.Console.Write(array[index] + " ");
        CreateArray(array, min, max, index + 1);
    }
    return array;
}

void ReverseArray(int[] array, int index)
{
    if (index < array.Length)
    {
        ReverseArray(array, index + 1);
        System.Console.Write(array[index] + " ");
    }
}

System.Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[size];
myArray = CreateArray(myArray, min, max, 0);
System.Console.WriteLine();
ReverseArray(myArray, 0);