internal class Program
{
    private static void Main(string[] args)
    {
        Doubly a = new Doubly(1);
        a.add(2);
        a.add(3);
        a.add(4);
        a.remove(1);
        a.printall();
        

        
    }
}