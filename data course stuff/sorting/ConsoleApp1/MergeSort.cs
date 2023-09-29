using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

class MergeSort
{
    public int[] sort(int[] arr)
    {
        int[] aux = new int[arr.Length];
        sort(arr, aux, 0, arr.Length-1);
        return arr;
    }

    public static void sort(int[] arr, int[] aux, int min, int max)
    {
        if (min != max)
        {
            int mid = (min+max)/2;
            sort(arr,aux,min,mid);
            sort(arr,aux,mid+1,max);
            merge(arr,aux,min,mid,max);
        }
        
    }

    public static void merge(int[] arr, int[] aux, int min, int mid, int max)
    {
        for (int r = min; r <= max ; r++)
            aux[r] = arr[r];
        int i = min;
        int j = mid+1;
        for (int k = min; k <= max ; k++) //index out of bounds here?
        {
            if (i > mid)
                arr[k] = aux[j++];
            else if (j > max)
                arr[k] = aux[i++];
            else if (aux[i] < aux[j])
                arr[k] = aux[i++];
            else
                arr[k] = aux[j++];
        }
    }
}

    // public int[] sort(int[] arr) this didnt work because its not recursive
    // {
    //     InsertionSort insertion = new InsertionSort();
    //     int[] aux = new int[arr.Length/2]; //index out of bounds here maybe
    //     for (int i = 0 ; i < arr.Length/2 ; i++)
    //         aux[i] = arr[i]; //aux now holds array elements from 0 to length/2
    //     insertion.sort(aux);
    //     insertion.sort(arr,arr.Length/2+1);
    //     //both are sorted, time 2 merge
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         int j = 0; int k = arr.Length/2+1; // j is for aux, k is for arr
    //         if (arr[j]<arr[k])
    //             {arr[i] = arr[j];j++;}
    //         else 
    //             {arr[i] = arr[k];k++;}
    //     }
    //     return arr;
    // }
