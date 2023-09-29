using System.Diagnostics;
using static Util; 
 
class Program
{
    private static void Main(string[] args)
    {
        Stopwatch timer = new Stopwatch();
        InsertionSort insertion = new InsertionSort();
        SelectionSort selection = new SelectionSort();
        MergeSort merge = new MergeSort();
        MergeSort2 merge2 = new MergeSort2();

        long insAverage = 0; long insTotal = 0;
        long selAverage = 0; long selTotal = 0;
        long merAverage = 0; long merTotal = 0;
        long me2Average = 0; long me2Total = 0;
        int arraysize = 10000;
        int repetitions = 10;
        // bool ticksorms = true; //false is ms, true is tick

        int[] array = unsorted(arraysize);
        int[] array2 = new int[arraysize];
        for (int i = 0; i < arraysize ; i++)
            array2[i] = array[i];
        
        timer.Start();
        insertion.sort(array2);
        timer.Stop();
        Console.WriteLine("INSERTION: " + timer.ElapsedTicks);
        timer.Reset();
        for (int i = 0; i < arraysize ; i++)
            array2[i] = array[i];
        timer.Start();
        selection.sort(array2);
        timer.Stop();
        Console.WriteLine("SELECTION: " + timer.ElapsedTicks);
        timer.Reset();
        for (int i = 0; i < arraysize ; i++)
            array2[i] = array[i];
        timer.Start();
        merge.sort(array2);
        timer.Stop();
        Console.WriteLine("MERGE: " + timer.ElapsedTicks);
        timer.Reset();
        for (int i = 0; i < arraysize ; i++)
            array2[i] = array[i];
        timer.Start();
        merge2.sort(array2);
        timer.Stop();
        Console.WriteLine("MERGE2: " + timer.ElapsedTicks);
        timer.Reset();
        // timer.Reset();

        // if (ticksorms == true)
        // for (int i = 0; i < repetitions ; i++)
        // {
        //     int[] testarr = unsorted(arraysize);
        //     int[] arr = new int[arraysize];
        //     for (int j = 0; j < arraysize ; j++)
        //         arr[i] = testarr[i];
        //     //SELECTION
        //     timer.Start();
        //     selection.sort(arr);
        //     timer.Stop();
        //     selTotal += timer.ElapsedTicks;
        //     timer.Reset();
        //     for (int j = 0; j < arraysize ; j++)
        //         arr[i] = testarr[i];
        //     //INSERTION
        //     timer.Start();
        //     insertion.sort(arr);
        //     timer.Stop();
        //     insTotal += timer.ElapsedTicks;
        //     timer.Reset();
        //     for (int j = 0; j < arraysize ; j++)
        //         arr[i] = testarr[i];
        //     //MERGE
        //     timer.Start();
        //     merge.sort(arr);
        //     timer.Stop();
        //     merTotal += timer.ElapsedTicks;
        //     timer.Reset();
        //     for (int j = 0; j < arraysize ; j++)
        //         arr[i] = testarr[i];
        //     //MERGE2
        //     timer.Start();
        //     merge2.sort(arr);
        //     timer.Stop();
        //     me2Total += timer.ElapsedTicks;
        //     timer.Reset();
            
        // }
        // else 
        // for (int i = 0; i < repetitions ; i++)
        // {
        //     int[] arr = unsorted(arraysize);
        //     //INSERTION
        //     timer.Start();
        //     insertion.sort(arr);
        //     timer.Stop();
        //     insTotal += timer.ElapsedMilliseconds;
        //     timer.Reset();
        //     arr = unsorted(arraysize);
        //     //SELECTION
        //     timer.Start();
        //     selection.sort(arr);
        //     timer.Stop();
        //     selTotal += timer.ElapsedMilliseconds;
        //     timer.Reset();
        //     arr = unsorted(arraysize);
        //     //MERGE
        //     timer.Start();
        //     merge.sort(arr);
        //     timer.Stop();
        //     merTotal += timer.ElapsedMilliseconds;
        //     timer.Reset();
        //     arr = unsorted(arraysize);
        //     //MERGE2
        //     timer.Start();
        //     merge2.sort(arr);
        //     timer.Stop();
        //     me2Total += timer.ElapsedMilliseconds;
        //     timer.Reset();
        // }

        // insAverage = insTotal/repetitions;
        // selAverage = selTotal/repetitions;
        // merAverage = merTotal/repetitions;
        // me2Average = me2Total/repetitions;

        // if (ticksorms == true)
        // {
        // Console.WriteLine("BENCHMARK RESULTS");
        // // Console.WriteLine("SELECTION TOTAL:" + selTotal/10 + "us");
        // // Console.WriteLine("INSERTION TOTAL:" + insTotal/10 + "us");
        // // Console.WriteLine("MERGE TOTAL:" + merTotal/10 + "us");
        // // Console.WriteLine("MERGE2 TOTAL:" + me2Total/10 + "us");
        // Console.WriteLine("SELECTION AVERAGE:" + selAverage/10 + "us");
        // Console.WriteLine("INSERTION AVERAGE:" + insAverage/10 + "us");
        // Console.WriteLine("MERGE AVERAGE:" + merAverage/10 + "us");
        // Console.WriteLine("MERGE2 AVERAGE:" + me2Average/10 + "us");
        // }
        // else{
        // Console.WriteLine("BENCHMARK RESULTS");
        // // Console.WriteLine("SELECTION TOTAL:" + selTotal + "ms");
        // // Console.WriteLine("INSERTION TOTAL:" + insTotal + "ms");
        // // Console.WriteLine("MERGE TOTAL:" + merTotal + "ms");
        // // Console.WriteLine("MERGE2 TOTAL:" + me2Total + "ms");
        // Console.WriteLine("SELECTION AVERAGE:" + selAverage + "ms");
        // Console.WriteLine("INSERTION AVERAGE:" + insAverage + "ms");
        // Console.WriteLine("MERGE AVERAGE:" + merAverage + "ms");
        // Console.WriteLine("MERGE2 AVERAGE:" + me2Average + "ms");
        // }

        


    }
    
}