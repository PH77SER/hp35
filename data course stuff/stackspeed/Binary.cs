public class Binary{

    int last;
    int first;


    public Boolean search(int[] array, int key)
    {
        first = 0;
        last = array.Length-1;


        while (true)
        {
            int index = (last+first)/2;

            if (key == array[index])
                return true;
            if (key > array[index] && key < last)
            {
                first = array[index];
            }
            if (key < array[index] && key > first)
            {
                last = array[index];
            }
            if (first == last || first > last)
            {
                return false;
            }

        throw new Exception("uhhhhhh array exited out of infinity ig?");
        }
    }
}

