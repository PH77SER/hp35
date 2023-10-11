using System.ComponentModel.DataAnnotations;
using System.Globalization;
using static Util;

class SelectionSort //TODO: TEST THIS
{
    public int[] sort(int[] array)
    {
        int i; int j;
        for (i = 0; i < array.Length - 1 ; i++)
        {
            int minimum = array.Length-1;
            for (j = i ; j < array.Length ; j++)
            {
                if (array[j]<array[minimum])
                    minimum = j;
            }
            swap(ref array[i], ref array[minimum]);
        }
        return array;
    }
}
