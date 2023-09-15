using static Util; 
 
class Program
{
    private static void Main(string[] args)
    {
        InsertionSort insertion = new InsertionSort();
        SelectionSort selection = new SelectionSort();
        int length = 10;
        Console.WriteLine("length of array:");
        //length = Console.Read();
        Console.WriteLine("INSERTION");
        int[] array = unsorted(length);
        insertion.sort(array);
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + ",");
        Console.WriteLine("\n");
        array = unsorted(length);
        Console.WriteLine("SELECTION");
        selection.sort(array);
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + ",");
        Console.WriteLine("\n" + "DONE");

    }
    
}