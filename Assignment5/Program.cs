using System.Threading.Channels;

namespace Assignment5
{

    internal class Program
    {
        #region 19-Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
        //static void Identity(int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++) 
        //        {
        //            if (i == j)
        //            {
        //                Console.Write(1);
        //            }
        //            else
        //            {
        //                Console.Write(0);
        //            }
        //        }
        //        Console.WriteLine(); 
        //    }
        //}
        //static void Main()
        //{
        //    Console.WriteLine("Enter n");
        //    int n = int.Parse(Console.ReadLine());
        //    Identity(n);
        //}

        #endregion
        #region 20- Write a program in C# Sharp to find the sum of all elements of the array
        //static void Cal_sum(int[] Array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        sum = sum + Array[i];
        //    }
        //    Console.WriteLine(sum);
        //}
        //static void Main()
        //{

        //    int[] Array = { 1, 2, 3, 4, 5 };

        //    Cal_sum(Array);
        //}
        #endregion

        #region 21-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        //static void merge(int[] Array1, int[] Array2) 
        //{
        //    int [] merge_array = new int[Array1.Length + Array2.Length];

        //    Array1.CopyTo(merge_array, 0);
        //    Array2.CopyTo(merge_array,Array1.Length);

        //    Array.Sort(merge_array);
        //    foreach (int i in merge_array)
        //    {
        //        Console.Write($" {i}" );
        //    }
        //    Console.WriteLine();
        //}
        //static void Main()
        //{
        //    int[] array1 = { 5, 1, 9 };
        //    int[] array2 = { 3, 7, 2 };
        //    merge(array1, array2);

        //}
        #endregion
        #region #region 23- Write a program in C# Sharp to find maximum and minimum element in an array
        //static void Main()
        //{
        //    int[] array = { 10,1, 2, 3, 4, 5 };
        //    max_min(array);  
        //}
        //static void max_min(int[] Array)
        //{
        //    int max = Array[0];
        //    int min = Array[0];
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        if (Array[i] > max)
        //        {
        //            max = Array[i];
        //        }
        //        if (Array[i] < min)
        //        {
        //            min = Array[i];
        //        }

        //    }
        //    Console.WriteLine(max);
        //    Console.WriteLine(min);
        //}
        //static void Main()
        //{
        //    int[] array = { 10, 1, 2, 3, 4, 5 };
        //    max_min(array);
        //}
        #endregion
        #region 24- Write a program in C# Sharp to find the second largest element in an array.
        //static void secondlarge(int[] Array) 
        //{
        //    int largest = int.MinValue;
        //    int sec = int.MinValue;

        //    foreach (int i in Array)
        //    {
        //        if (i > largest)
        //        {
        //            sec = largest;
        //            largest = i;                    
        //        }
        //        else if (i >sec && i<largest)
        //        {
        //            sec = i;

        //        }
        //    }
        //    Console.WriteLine(sec);
        //}

        //static void Main()
        //{
        //    int[] array = { 10, 1, 2, 3, 4, 5 };
        //    secondlarge(array);
        //}
        #endregion

        #region 25 Consider an Array of Integer values with size N, having values as in this Example

        //static void longdistance(int[] Array)
        //{
        //    int maxdistance = 0;
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        for (int j = i + 1; j < Array.Length; j++)
        //        {
        //            if (Array[i] == Array[j])
        //            {
        //                int distance = j - i-1;
        //                if (distance > maxdistance)
        //                {
        //                    maxdistance = distance;
        //                }

        //            }
        //        }

        //    }
        //    Console.WriteLine(maxdistance);
        //}
        //static void Main()
        //{

        //    Console.Write("Enter the size of array ");
        //    int n = int.Parse(Console.ReadLine());

        //    int[] array = new int[n];
        //    Console.WriteLine("Enter the elements of array ");
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write($"Index of {i} :");
        //        array[i] = int.Parse(Console.ReadLine());
        //    }


        //    longdistance(array);
        //}
        #endregion
        #region 26 Given a list of space separated words, reverse the order of the words.
        //static void reverse(string name)
        //{
        //    string[] y = name.Split(' ');
        //    Array.Reverse(y);
        //    Console.WriteLine(string.Join(" ", y));//searched on this line
        //}
        //static void Main()
        //{
        //    string z = Console.ReadLine();
        //    reverse(z);

        //}
        #endregion

        #region  28- Write a Program to Print One Dimensional Array in Reverse Order

        //static void rev(int[]Array1)
        //{
        //    Array.Reverse(Array1);
        //    foreach (int i in Array1)
        //    {
        //        Console.Write(i+" ");
        //    }
        //    Console.WriteLine();
            
        //}
        //static void Main()
        //{
        //    int[] A = { 1, 2, 3, 4, 5 };
            
        //    rev(A);
        //}
        #endregion








        ////////////////////////////////////////////////////////////////////     
        //Functions Questions
        #region 1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        //static void Swap_ref(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        //static void Swap_value(int x,int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}

        //static void Main(string[] args)
        //{            
        //int a=2; int b=4;

        //Swap_ref(ref a, ref b);
        //Console.WriteLine($"swap by ref: {a},{b}");

        //int c = 5; int d = 6;
        //Swap_value(c, d);
        //Console.WriteLine($"swap by values: {c},{d}");

        //////////////////////////////////////////////////


        //}
        #endregion
        #region 2-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

        //static void SumOfDigit(int number)
        //{
        //    int sum = 0;
        //    int originalNumber = number;
        //    while (number != 0)
        //    {
        //        sum += number % 10 ; //modules
        //        number /= 10;//divided
        //    }
        //    Console.WriteLine($"The sum of the digits of the number {originalNumber} is: {sum}");
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter a number ");
        //    int input = int.Parse(Console.ReadLine());

        //    SumOfDigit(input);

        //}
        #endregion
        #region 3-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .
        //static void IsPrime(int number)
        //{
        //    if (number % 2 == 1)
        //    {
        //        Console.WriteLine($"Number of {number} is Prime ");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Number of {number} is NotPrime ");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter a number ");
        //    int number = int.Parse(Console.ReadLine());           
        //    IsPrime(number);
        //}
        #endregion
        #region 4-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .
        //static void fac(int number)
        //{
        //    long factorial=1;//i searched about this line
        //    for (int i = 1; i <= number; i++)
        //    {

        //       factorial = i* factorial;
        //    }
        //    Console.WriteLine($"factorial of {number} is {factorial}");
        //}
        //static void Main(string[] args) 
        //{
        //    Console.Write("Enter a number ");
        //    int input = int.Parse(Console.ReadLine());

        //    fac(input);
        //}
        #endregion




    }
}










