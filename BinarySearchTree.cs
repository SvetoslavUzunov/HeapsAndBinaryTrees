namespace HeapsAndBinaryTrees;

public class BinarySearchTree<T> where T : IComparable<T>
{
    public BinarySearchTree(BinarySearchTreeNode<T> root = null)
    {
        this.Root = root;
    }

    public BinarySearchTreeNode<T> Root { get; set; }

    public void Insert(T value, BinarySearchTreeNode<T> node)
    {
        if (node == null)
        {
            node = new BinarySearchTreeNode<T>(value);
            Root = node;
            return;
        }

        if (node.Value.CompareTo(value) > 0)
        {
            if (node.LeftChild == null)
            {
                node.LeftChild = new BinarySearchTreeNode<T>(value);
                return;
            }
            else
            {
                Insert(value, node.LeftChild);
            }
        }
        else
        {
            if (node.RightChild == null)
            {
                node.RightChild = new BinarySearchTreeNode<T>(value);
                return;
            }
            else
            {
                Insert(value, node.RightChild);
            }
        }
    }

    public bool Contains(T value, BinarySearchTreeNode<T> node)
    {
        if (node == null) return false;
        if (node.Value.CompareTo(value) == 0)
        {
            return true;
        }
        if (node.Value.CompareTo(value) > 0)
        {
            return Contains(value, node.LeftChild);
        }
        else
        {
            return Contains(value, node.RightChild);
        }
    }

    public BinarySearchTreeNode<T> Search(T value, BinarySearchTreeNode<T> node)
    {
        if (node == null) return null;
        if (node.Value.CompareTo(value) == 0)
        {
            return node;
        }
        if (node.Value.CompareTo(value) > 0)
        {
            return Search(value, node.LeftChild);
        }
        else
        {
            return Search(value, node.RightChild);
        }
    }

    public string DFS(BinarySearchTreeNode<T> node, int spaces)
    {
        string result = "";
        if (node.LeftChild != null)
        {
            result += DFS(node.LeftChild, spaces + 3);
        }
        result += $"{new string(' ', spaces)}{node.Value}\n";
        if (node.RightChild != null)
        {
            result += DFS(node.RightChild, spaces + 3);
        }
        return result;
    }
}