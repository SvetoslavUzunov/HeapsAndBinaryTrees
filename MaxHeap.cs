namespace HeapsAndBinaryTrees;

public class MaxHeap<T> where T : IComparable<T>
{
    private List<T> heap;
    public MaxHeap()
    {
        heap = new List<T>();
    }

    public int Size { get { return heap.Count; } }

    public T this[int index]
    {
        get { return heap[index]; }
        set { heap[index] = value; }
    }

    public T Peek()
    {
        return heap[0];
    }

    public void Add(T element)
    {
        heap.Add(element);
        Heapify(heap.Count - 1);
    }

    private void Heapify(int index)
    {
        if (index == 0) return;
        int parentIndex = (index - 1) / 2;
        if (heap[index].CompareTo(heap[parentIndex]) > 0)
        {
            (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);
            Heapify(parentIndex);
        }
    }

    public string DFS(int index, int spaces)
    {
        string result = "";
        int leftChild = index * 2 + 1;
        int rightChild = index * 2 + 2;
        if (leftChild < heap.Count)
        {
            result += DFS(leftChild, spaces + 3);
        }

        result += $"{new string(' ', spaces)}{heap[index]}\n";

        if (rightChild < heap.Count)
        {
            result += DFS(rightChild, spaces + 3);
        }

        return result;
    }
}