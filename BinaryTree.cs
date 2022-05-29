namespace HeapsAndBinaryTrees;

public class BinaryTree<T>
{
    public BinaryTree(BinaryTreeNode<T> root)
    {
        this.Root = root;
    }

    public BinaryTreeNode<T> Root { get; set; }

    public string DFS(BinaryTreeNode<T> node, int spaces)
    {
        string result = $"{new string(' ', spaces)} {node.Value}\n";

        if (node != null)
        {
            result += DFS(node.LeftChild, spaces + 3);
        }
        if (node.RightChild != null)
        {
            result += DFS(node.RightChild, spaces + 3);
        }

        return result;
    }

    public string DFSPreOrder(BinaryTreeNode<T> node, int spaces)
    {
        string result = $"{new string(' ', spaces)} {node.Value}\n";

        if (node.LeftChild != null)
        {
            result += DFSPreOrder(node.LeftChild, spaces + 3);
        }
        if (node.RightChild != null)
        {
            result += DFSPreOrder(node.RightChild, spaces + 3);
        }

        return result;
    }

    public string DFSInOrder(BinaryTreeNode<T> node, int spaces)
    {
        string result = "";
        if (node.LeftChild != null)
        {
            result += DFSInOrder(node.LeftChild, spaces + 3);
        }

        result += $"{new string(' ', spaces)} {node.Value}\n";

        if (node.RightChild != null)
        {
            result += DFSInOrder(node.RightChild, spaces + 3);
        }

        return result;
    }

    public string DFSPostOrder(BinaryTreeNode<T> node, int spaces)
    {
        string result = "";

        if (node.LeftChild != null)
        {
            result += DFSPostOrder(node.LeftChild, spaces + 3);
        }

        if (node.RightChild != null)
        {
            result += DFSPostOrder(node.RightChild, spaces + 3);
        }
        result += $"{new string(' ', spaces)} {node.Value}\n";

        return result;
    }
}
