using System.ComponentModel;

class BinaryTree
{
    public class Node
    {
        public int value;
        public int key;
        public Node? left;
        public Node? right;
        public Node(int key, int value)
        {
            this.value = value;
            this.key = key;
            this.right = null;
            this.left = 
            null;
        }
        public void print()
        {
            if(left != null)
                left.print();
            Console.WriteLine(" key: " + key + "\tvalue: " + value);
            if(right != null)
                right.print();
        }
    }
    public Node root;
    public BinaryTree(int key, int item)
    {
        this.root = new Node(key,item);
    }
    public void add(int key, int value) //logic might be wrong on where to go and build new nodes
    {
        Node next = root;
        while (next != null)
        {
            if (key == next.key)
                {next.value = value;return;}
            else if (key < next.key && next.left != null)
                next = next.left;
            else if (next.right != null)
                next = next.right;
        }
        if (next != null) //might not work
            if (key < next.key)
                next.left = new Node (key,value);
            else
                next.right = new Node(key,value);
        return;
    }
    public void remove(int key)//no point implementing this
    {
        return; 
    }
    public int? lookup(int key) //CHECK IF IT WORKS
    {
        Node? current = root;
        while (current != null)
        {
            if (key == current.key)
                return current.value;
            else if (key < current.key)
                current = current.left;
            else if (key > current.key)
                current = current.right;
        }
        return null;
    }

    
    

}