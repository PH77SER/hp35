using static Util;
public class InsertionSort
{
    public int[] sort(int[] inputArray)
    {
        // int i;
        // bool sorted = false;
        // while (!sorted)
        // {
        //     sorted = true;
        //     for (i = 1; i < inputArray.Length; i++)
        //     {
        //         if (inputArray[i-1] > inputArray[i])
        //             {swap(ref inputArray[i-1],ref inputArray[i]); sorted = false; }

        //     }
        // }
        // return array;

        for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                  }
            }
            return inputArray;      
    }
}