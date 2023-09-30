internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        int treesize = 10;
        BinaryTree tree = new BinaryTree(10, 10+1000);
        tree.add(1,1);
        // for (int i = 1 ; i <= treesize ; i++)
        // {
        //     tree.add(i, i+1000);
        // }
        tree.root.print();
    }
}