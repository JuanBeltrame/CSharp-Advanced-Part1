using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Program
{
    static void DisplayElements(int[] intArray)
    {
        foreach (int item in intArray)
            Console.Write($"{item}, ");
        Console.WriteLine();
    }

    static void DisplayElements(double[] doubleArray)
    {
        foreach (double item in doubleArray)
            Console.Write($"{item}, ");
        Console.WriteLine();
    }

    static void DisplayElements(string[] stringArray)
    {
        foreach (string item in stringArray)
            Console.Write($"{item}, ");
        Console.WriteLine();
    }

    static void DisplayGenericElements<Thing>(Thing[] array) 
    {
        foreach (Thing item in array)
            Console.Write($"{item}, ");
        Console.WriteLine(  );
    }

    private static void Main(string[] args)
    {
        int[] intArray = [1, 2, 3];
        double[] doubleArray = [1.1, 2.2, 3.3];
        string[] stringArray = ["uno", "dos", "tres"];
        

        DisplayGenericElements(intArray);
        DisplayGenericElements(doubleArray);
        DisplayGenericElements(stringArray);
    }
}