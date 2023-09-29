using System.Data;
using System.Transactions;

public class Doubly
{

    public class Cell
    {
        public int? value;
        public Cell? next;
        public Cell? prev;
        public Cell (int val, Cell? prv, Cell? nxt) //cell cosntructor
        {
            value = val;
            next = nxt;
            prev = prv;
        }
    }

    Cell first;
    Cell last;
    int length = 1;

    public Doubly (int item) //doubly constructor
    {
        first = new Cell(item, null, null);
        last = first;
    }
    public void add(int item)
    {
        length++;
        if (length == 1)
        {
            first.next = new Cell(item, first, null);
            last = first.next; //I HOPE THIS FUCKING WORKS. CHECK ME
        }

        else
        {
            last.next = new Cell(item,last,null);
            last = last.next; //I HOPE THIS WORKS [2]
        }
    }

    public Cell find(int item)
    {
        Cell current = first;
        while (current.next != null)
        {
            if (item == current.value)
                return current;
            else
                current = current.next;
        }
        return new Cell(-1, null, null);
    }

    public void remove(int item)
    {
        if (first.value == item) //SPECIAL CASE HANDLING
            if (first.next == null) //FIRST VALUE IS REMOVED BUT ITS THE ONLY VALUE
                {length = 0; return;}
            else //FIRST VALUE IS REMOVED BUT ITS NOT THE ONLY VALUE
                {first = first.next; length--; return;}
                
        Cell? current = first;

        while (current.next != null)
        {
            if (current.next.value == item)
            {
                current.next.prev = current; //GOOD ENOUGH. FUCK THIS
                current.next = current.next.next;
                length--; 
                return;
            }
            else
                current = current.next;
        }
    }

    public Cell? unlink(Cell a)
    {
        if (a.prev != null)
        {
            a = a.prev;
            if (a.next != null)
            {
                a.next.prev = a; //MIGHT NOT WORK
                a.next = a.next.next;
            }
        }
        return a.next;
    }

    public void insert(Cell a)
    {
        a.next = first;
        a.next.next = first.next; //MIGHT BREAK
        a.prev = null;
        first = a;
    }
    public void printall()
    {
        Cell? current = first;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }    
}