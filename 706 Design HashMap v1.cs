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
        int index = getIndex(key);
        chains[index] = Put(chains[index], key, value);
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
        Node n = Get(chains[getIndex(key)], key);

        if (n == null)
            return -1;

        return n.Value;
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
        int index = getIndex(key);
        chains[index] = Remove(chains[index], key);
    }

    private Node Get(Node node, int key)
    {
        if (node == null)
        {
            return node;
        }

        if (node.Key == key)
        {
            return node;
        }

        return Get(node.Next, key);
    }


    private Node Remove(Node node, int key)
    {
        if (node == null)
        {
            return null;
        }

        if (node.Key == key)
        {
            return node.Next;
        }

        node.Next = Remove(node.Next, key);
        return node;
    }

    private Node Put(Node node, int key, int value)
    {
        if (node == null)
        {
            return new Node(key, value);
        }

        if (node.Key == key)
        {
            node.Value = value;
            return node;
        }

        node.Next = Put(node.Next, key, value);
        return node;
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
