namespace HeapsAndBinaryTrees;

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> priorityQueue;
    public PriorityQueue()
    {
        priorityQueue = new List<T>();
    }
    public int Size { get { return priorityQueue.Count; } }

    public T Peek()
    {
        return priorityQueue[0];
    }

    public void Enqueue(T element)
    {
        priorityQueue.Add(element);
        Heapify(priorityQueue.Count - 1);
    }

    public T Dequeue()
    {
        T top = priorityQueue[0];
        priorityQueue[0] = priorityQueue[priorityQueue.Count - 1];
        priorityQueue.RemoveAt(priorityQueue.Count - 1);

        HeapifyDown(0);
        return top;
    }

    private void Heapify(int index)
    {
        if (index == 0) return;
        int parentIndex = (index - 1) / 2;
        if (priorityQueue[index].CompareTo(priorityQueue[parentIndex]) > 0)
        {
            (priorityQueue[index], priorityQueue[parentIndex]) = (priorityQueue[parentIndex], priorityQueue[index]);
            Heapify(parentIndex);
        }
    }

    private void HeapifyDown(int index)
    {
        int leftChild = index * 2 + 1;
        int rightChild = index * 2 + 2;
        int maxChildIndex = leftChild;

        if (leftChild >= priorityQueue.Count) return;
        if (rightChild < priorityQueue.Count && priorityQueue[leftChild].CompareTo(priorityQueue[rightChild]) < 0)
        {
            maxChildIndex = rightChild;
        }

        if (priorityQueue[index].CompareTo(priorityQueue[maxChildIndex]) < 0)
        {
            T temp = priorityQueue[index];
            priorityQueue[index] = priorityQueue[maxChildIndex];
            priorityQueue[maxChildIndex] = temp;

            HeapifyDown(maxChildIndex);
        }
    }

    public string DFS(int index, int spaces)
    {
        string result = "";
        int leftChild = index * 2 + 1;
        int rightChild = index * 2 + 2;
        if (leftChild < priorityQueue.Count)
        {
            result += DFS(leftChild, spaces + 3);
        }
        result += $"{new string(' ', spaces)}{priorityQueue[index]}\n";
        if (rightChild < priorityQueue.Count)
        {
            result += DFS(rightChild, spaces + 3);
        }

        return result;
    }
}