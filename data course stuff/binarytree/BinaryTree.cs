using System.ComponentModel;

class BinaryTree
{
    public Node root;
    public BinaryTree(int key, int item)
    {
        this.root = new Node(key,item);
    }
    public void add(int key, int value)
    {
        Node? next = root;
        while (next != null)
        {
            if (key == next.key)
                {next.value = value;return;}
            else if (key < next.key)
                if (next.left == null)
                    next.left = new Node(key,value);
                else next = next.left;
            else
                if (next.right == null)
                    next.right = new Node(key,value);
                else next = next.right;
        }
        next = new Node(key,value);
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