

static class Util
{

    public static void swap(ref int a,ref int b)
    {
        int dummy = a;
        a = b;
        b = dummy;
    }
    public static int[] unsorted(int maxlength)
    {
        Random rand = new Random();
        int[] array = new int[maxlength];
        for (int i = 0; i < maxlength ; i++)
            array[i] = rand.Next(1000);
        return array;
    }

}