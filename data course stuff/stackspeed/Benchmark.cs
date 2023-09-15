using System.Diagnostics;

public class Bench {


	private static Boolean Linearsearch(int[] array, int key)
    {
        for (int i = 0; i < array.Length ; i++)
        {
            if (array[i] == key)
                return true;
        }
        return false;
    }
    private static Boolean Binarysearch(int[] array, int key)
    {
        int first = 0;
        int last = array.Length-1;
        while (true)
        {
            int index = (last+first)/2;

            if (key == array[index])
                return true;
            if (key > array[index])
                first = index+1;
            else if (key < array[index])
                last = index-1;
            if (first > last)
                return false;
        }
		throw new Exception("uhhhhhh array exited out of infinity ig?");
    }



    private static void linear(int[] array, int[] indx) {
	for (int i = 0; i < indx.Length ; i++) {
	    Linearsearch(array, indx[i]);
	}
    }
    

    private static void binary(int[] array, int[] indx) {
	for (int i = 0; i < indx.Length ; i++) {
        Binarysearch(array, indx[i]);
	}
    }

    private static int smart(int[] array1, int[] array2) 
    {
        int counter = 0; int i = 0; int j = 0;
        while (i<array1.Length-1 && j<array2.Length-1)
        {
            if (array1[i] > array2[j])
                j++;
            if (array1[i] < array2[j])
                i++;
            else {counter++; i++; j++;}
        }
        return counter;
    }

       
    private static int[] sorted(int n) {
	Random rnd = new Random();	
	int[] array = new int[n];
	int nxt = rnd.Next(10);

	for (int i = 0; i < n ; i++) {
	    array[i] = nxt;
	    nxt += rnd.Next(10) + 1 ;
	}	
	return array;
    }


    private static int[] keys(int loop, int n) {
	Random rnd = new Random();	
	int[] indx = new int[loop];
	for (int i = 0; i < loop ; i++) {
	    indx[i] = rnd.Next(n*5);
	}	
	return indx;
    }

    private static int[] unsorted(int n)
    {
        Random rnd = new Random();
        int[] returnme = new int[n];
        for (int i = 0 ; i < n ; i++)
            returnme[i] = rnd.Next(n);
        return returnme;
    }

    
    public static void Main(String[] args) {

    Console.WriteLine("n - linear - binary - smart");

	for ( int n = 100; n <= 1600 ; n = n + 100) 
    {
        Stopwatch stop = new Stopwatch();
	    int loop = 1000;
	    int[] array = sorted(n);
        //int[] array2 = sorted(n);
	    int[] array2 = keys(loop, n);


	    int k = 1000;
	    

        stop.Reset();
        for (int i = 1; i<=k ;i++)
        {
            stop.Start();
		    linear(array, array2);
            stop.Stop();
        }
        Console.Write( n.ToString());
		Console.Write("&");
		Console.Write(stop.ElapsedMilliseconds);
        Console.Write("&");


        stop.Reset();
        for (int i = 1; i<=k ;i++)
        {
            stop.Start();
		    binary(array, array2);
            stop.Stop();
        }
		Console.Write(stop.ElapsedMilliseconds);
                Console.Write("\\");
        Console.WriteLine("\\");
		stop.Reset();
        // for (int i = 1; i<=k ;i++)
        // {
        //     stop.Start();
		//     smart(array, array2);
        //     stop.Stop();
        // }
		// Console.Write(stop.ElapsedMilliseconds);
		stop.Reset();
    }
}

}

