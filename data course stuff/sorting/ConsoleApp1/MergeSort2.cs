using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

class MergeSort2
{
    public int[] sort(int[] arr)
    {
        
        int[] aux = new int[arr.Length];
        for (int r = 0; r <= arr.Length-1 ; r++)
            aux[r] = arr[r];
        sort(arr, aux, 0, arr.Length-1);
        return arr;
    }

    public static void sort(int[] arr, int[] aux, int min, int max)
    {
        if (min != max)
        {
            int mid = (min+max)/2;
            sort(aux,arr,min,mid);
            sort(aux,arr,mid+1,max);
            merge(arr,aux,min,mid,max);
        }
    }

    public static void merge(int[] arr, int[] aux, int min, int mid, int max)
    {
        int i = min;
        int j = mid+1;
        for (int k = min; k <= max ; k++) //index out of bounds here?
        {
            if (i > mid)
            {
                arr[k] = aux[j++];
            }
            else if (j > max)
            {
                arr[k] = aux[i++];
            }
            else if (aux[i] < aux[j])
            {
                arr[k] = aux[i++];
            }
            else
            {
                arr[k] = aux[j++];
            }
        }
    }
}
