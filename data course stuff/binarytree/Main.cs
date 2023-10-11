using System.Diagnostics;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        Stopwatch stop = new Stopwatch();
        stop.Reset();
        int[] treesize = {10, 100, 250, 500, 1000, 2500, 5000, 10000,100000, 1000000};
        BinaryTree tree = new BinaryTree(3, 10+1000);

        foreach (int size in treesize)
        {
            stop.Start();
            for (int i = 1 ; i <= size ; i++)
            {
                tree.add(rand.Next(size), i);
            }
            stop.Stop();
            Console.WriteLine(size + "&" + String.Format("{0:0.00}",(float)stop.ElapsedTicks/10000) + "ms" + "\\" + "\\");
            stop.Reset();
            //tree.root.print();

        }

    }
}