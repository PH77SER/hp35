using System.ComponentModel;

public class Item
{
    public int value = 0;
    public itemType type;

    public Item(int value) //inputting values
    {
        this.value = value;
        this.type = itemType.VAL;
    }
    public Item(itemType type) //inputting expressions
    {
        if (type == itemType.VAL)
            throw new Exception("WRONG SYNTAX FOR VALUES");
        this.type = type;
        this.value = 0;
    }
}

public enum itemType
{
    VAL,
    ADD,
    SUB,
    MUL,
    DIV
}

