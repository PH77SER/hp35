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
            int minimum = int.MaxValue;
            for (j = i ; j < array.Length ; j++)
            {
                if (array[j]<minimum)
                    minimum = array[j];
            }
            swap(ref array[i], ref array[j]);
        }
        return array;
    }
}