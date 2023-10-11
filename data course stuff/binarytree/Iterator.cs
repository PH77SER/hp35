using System.Collections;
using System.ComponentModel.Design.Serialization;

class MyIterator
{
    BinaryTree tree;
    Stack<Node> stacc = new Stack<Node>(100);
    int? max;
    Node? current = null;
    public MyIterator(BinaryTree tree)
    {
        this.tree = tree;
        this.current = tree.root;
        stacc.Push(this.current);
        while (this.current.left != null)
            {
                this.current = this.current.left; //makes sure current is leftmost
                stacc.Push(this.current);
            }

    }
    public bool hasNext()
    {
        if (max != null && current != null)
            if (this.current.key == max)
                return false;
        else
            {
                Node newnode = this.tree.root;
                while (newnode.right != null)
                    newnode = newnode.right;
                this.max = newnode.key;
            }
        return true;
    }

    // public Node? next()
    // {
    //     if (this.hasNext() == false) //if we're at the end just return null, we're done
    //         return null;
    //     if (this.current == null) //edge case
    //         return null;
    //     int key = this.current.key; //key we're trynna find the next to
    //     if (this.current.right == null) //CASE: RIGHT NODE IS EMPTY
    //     {
    //         stacc.Pop();
    //         this.current = stacc.Peek();
    //         if (this.current.right == null) //CASE: RIGHT NODE EMPTY, PARENT'S RIGHT NODE IS EMPTY
    //             return this.current;
    //         else
    //         {
    //             this.current.
    //         }
    // }
}