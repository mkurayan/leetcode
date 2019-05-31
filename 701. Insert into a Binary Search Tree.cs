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
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null)
        {
            return new TreeNode(val);
        }

        // It is guaranteed that the new value does not exist in the original BST.
        if (root.val > val)
        {
            root.left = InsertIntoBST(root.left, val);
        }
        else
        {
            root.right = InsertIntoBST(root.right, val);
        }

        return root;
    }
}