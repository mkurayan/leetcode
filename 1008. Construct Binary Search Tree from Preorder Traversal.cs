public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Solution
{
    public TreeNode BstFromPreorder(int[] preorder)
    {
        TreeNode root = null;

        for (int i = 0; i < preorder.Length; i++)
        {
            root = AddNode(root, preorder[i]);
        }

        return root;
    }

    private TreeNode AddNode(TreeNode node, int val)
    {
        if (node == null)
        {
            return new TreeNode(val);
        }

        if (val < node.val)
        {
            node.left = AddNode(node.left, val);
        }
        else if (val > node.val)
        {
            node.right = AddNode(node.right, val);
        }

        return node;
    }
}
