/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> list = new List<int>();

        InorderTraversal(root, list);

        return list;
    }

    private void InorderTraversal(TreeNode node, IList<int> list)
    {
        if (node == null)
        {
            return;
        }

        InorderTraversal(node.left, list);
        list.Add(node.val);
        InorderTraversal(node.right, list);
    }
}