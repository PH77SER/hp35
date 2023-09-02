public class Calculator
{
    Item[] expr = new Item[32];
    //StaticStack stack = new StaticStack();
    DynamicStack stack = new DynamicStack();  //TOGGLE ME 1/2


    public Calculator(Item[] expr)
    {
        this.expr = expr;
    }
    public Calculator(Item[] expr, int size)
    {
        this.expr = expr;
        //this.stack = new StaticStack(size);  
        this.stack = new DynamicStack(size);   //TOGGLE ME 2/2
    }

    
    public void run()
    {
        foreach (Item item in expr)
        {
            switch (item.type)
            {
                case itemType.VAL:
                {
                    stack.push(item.value);
                    break;
                }
                case itemType.ADD:
                {
                    int b = stack.pop();
                    int a = stack.pop();
                    stack.push(a+b);
                    break;
                }
                case itemType.SUB:
                {
                    int b = stack.pop();
                    int a = stack.pop();
                    stack.push(a-b);
                    break;
                }
                case itemType.MUL:
                {
                    int b = stack.pop();
                    int a = stack.pop();
                    stack.push(a*b);
                    break;
                }
                case itemType.DIV:
                {
                    int b = stack.pop();
                    int a = stack.pop();
                    stack.push(a/b);
                    break;
                }
            }
        }
        //stack.print();
    }
}