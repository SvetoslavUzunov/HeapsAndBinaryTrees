namespace HeapsAndBinaryTrees;

public class Program
{
    static void Main()
    {
        BinarySearchTree<int> binaryTree = new BinarySearchTree<int>();
        List<int> elements = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            elements.Add(i);
        }


        Insert(binaryTree, elements, 0, elements.Count);
        Console.WriteLine(binaryTree.DFS(binaryTree.Root, 0));

        Console.WriteLine(binaryTree.Contains(12, binaryTree.Root));
    }

    private static void Insert(BinarySearchTree<int> binaryTree, List<int> elements, int start, int end)
    {
        if (start >= end) return;

        int middle = (start + end) / 2;
        binaryTree.Insert(elements[middle], binaryTree.Root);
        Insert(binaryTree, elements, start, middle - 1);
        Insert(binaryTree, elements, middle + 1, end);
    }
}