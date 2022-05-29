namespace HeapsAndBinaryTrees;

public class BinaryTreeNode<T>
{
    public BinaryTreeNode(T value, BinaryTreeNode<T> leftChild = null, BinaryTreeNode<T> rightChild = null)
    {
        this.Value = value;
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public T Value { get; set; }
    public BinaryTreeNode<T> LeftChild { get; set; }
    public BinaryTreeNode<T> RightChild { get; set; }
}