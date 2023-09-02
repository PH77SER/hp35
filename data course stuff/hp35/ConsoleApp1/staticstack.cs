using System.Dynamic;

public class StaticStack
{
    int[] thestack = new int[32];
    int pointer = -1; //points to the CURRENT object, starts at index 0 with the first thinghy
    public StaticStack(){}
    public StaticStack(int size)
    {
        this.thestack = new int[size];
    }
    public void push(int x)
    {
        pointer++;
        thestack[pointer] = x;
    }
    public int pop()
    {
        int x = thestack[pointer];
        thestack[pointer] = 0;
        pointer--;
        return x;
    }
    public void print()
    {
        foreach (int x in thestack)
            Console.WriteLine(x);
    }
}