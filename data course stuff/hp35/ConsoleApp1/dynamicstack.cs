using System.Diagnostics.Metrics;
using System.Dynamic;

public class DynamicStack
{
    int[] thestack = new int[4];
    int pointer = -1; //points to the CURRENT object, starts at index 0 with the first thinghy
    int counter = 10; //this is used to count 10 push/pops under the new max dynamic size, and when it hits 0, it halves the size again

    public DynamicStack(){}
    public DynamicStack(int size)
    {
        this.thestack = new int[size];
    }
    public void push(int x)
    {
        if (counter != 0 && pointer+1 < thestack.Length/2) //STACK DECREASE CODE
            counter--;
        else 
            counter = 10;
        if (counter <= 0)
        {   int[] newstack = new int[thestack.Length/2];
            for (int i = 0; i < thestack.Length/2; i++)
                newstack[i] = thestack[i];
            thestack = newstack;  //STACK DECREASE CODE END
        }

        if (pointer+1 >= thestack.Length) //this is if the stack is too smol and needs embiggening
        {
            int[] newstack = new int[thestack.Length*2];
            for (int i = 0; i < thestack.Length; i++)
                newstack[i] = thestack[i];
            thestack = newstack;
        }

        pointer++;
        thestack[pointer] = x;
    }
    public int pop()
    {
        if (counter != 0 && pointer+1 < thestack.Length/2) //STACK DECREASE CODE
            counter--;
        else 
            counter = 10;
        if (counter <= 0)
        {   int[] newstack = new int[thestack.Length/2];
            for (int i = 0; i < thestack.Length/2; i++)
                newstack[i] = thestack[i];
            thestack = newstack;  //STACK DECREASE CODE END
        }
        
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