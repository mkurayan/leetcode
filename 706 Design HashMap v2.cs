public class MyHashMap
{
    private class Node
    {
        public int Key { get; }
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    private readonly int M = 97;
    private readonly Node[] chains;

    /** Initialize your data structure here. */
    public MyHashMap()
    {
        chains = new Node[M];
    }

    /** value will always be non-negative. */
    public void Put(int key, int value)
    {
        Node n = GetNode(key);

        if (n == null)
        {
            int index = getIndex(key);

            n = new Node(key, value);
            n.Next = chains[index];

            chains[index] = n;
        }
        else
        {
            n.Value = value;
        }
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
        Node n = GetNode(key);

        if (n == null)
            return -1;

        return n.Value;
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
        Node root = chains[getIndex(key)];

        if (root == null)
        {
            return;
        }

        if (root.Key == key)
        {
            chains[getIndex(key)] = chains[getIndex(key)].Next;
            return;
        }


        for (Node prev = chains[getIndex(key)], current = prev.Next; current != null;)
        {
            if (current.Key == key)
            {
                prev.Next = current.Next;
                break;
            }

            prev = current;
            current = current.Next;
        }
    }

    private Node GetNode(int key)
    {
        Node n = chains[getIndex(key)];

        while (n != null && n.Key != key)
        {
            n = n.Next;
        }

        return n;
    }

    private int getIndex(int key)
    {
        return key % M;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
