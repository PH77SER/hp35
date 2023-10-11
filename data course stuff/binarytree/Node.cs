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