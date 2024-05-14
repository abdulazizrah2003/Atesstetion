// Задача 1.


// void FromMtoN (int m , int n)
// {
//     if(m>n){
//         FromMtoN(m-1, n);
//         System.Console.WriteLine(m+" ");
//     }
// else if(n>m){
//     FromMtoN(n-1,m);
// System.Console.WriteLine(n+" "); 
// }
// else {
//     System.Console.WriteLine(m+" ");
// }
// }
// FromMtoN(2,6);

// Задача 2 



// int Akkerman(int m , int n)
//  {
//     if(m == 0)
//     {
//        return n+1;

//     }
//    else if(n == 0){
//         return Akkerman(m-1,1);
//     }
//     else{
//         return Akkerman(m-1,Akkerman (m,n-1));
//     }

//  }
//  Console.WriteLine(Akkerman(-1,0));


// Задача 3

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1); 
//     }
//     return array;
// }

// void NumMassive (int[] array, int i)
// {
    // if(i < array.Length)
    // {
//         NumMassive(array, i+1);
//         System.Console.Write(array[i] + " ");
//     }
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " "); 
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);
// NumMassive(array, 0);



string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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
SecondArrayWithIF(array1, array2);
PrintArray(array2);



