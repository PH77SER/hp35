using static Util;
public class InsertionSort
{
    public int[] sort(int[] array)
    {
        int i;
        bool sorted = false;
        while (!sorted)
        {
            sorted = true;
            for (i = 1; i < array.Length; i++)
            {
                if (array[i-1] > array[i])
                    {swap(ref array[i-1],ref array[i]); sorted = false; }

            }
        }
        return array;
    }

    public int[] sort(int[] array, int index) //OVERLOAD TO SORT FROM THIS POINT ONWARD
    {
        int i;
        bool sorted = false;
        while (!sorted)
        {
            sorted = true;
            for (i = index; i < array.Length; i++)
            {
                if (array[i-1] > array[i])
                    {swap(ref array[i-1],ref array[i]); sorted = false; }

            }
        }
        return array;
    }
}