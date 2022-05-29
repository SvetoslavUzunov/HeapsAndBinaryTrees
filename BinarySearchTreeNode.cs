namespace HeapsAndBinaryTrees;

public class BinarySearchTreeNode<T>
{
    public BinarySearchTreeNode(T value, BinarySearchTreeNode<T> leftChild = null, BinarySearchTreeNode<T> rightChild = null)
    {
        this.Value = value;
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }

    public T Value { get; set; }
    public BinarySearchTreeNode<T> LeftChild { get; set; }
    public BinarySearchTreeNode<T> RightChild { get; set; }
}