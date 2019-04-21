/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

using System.Text;

public class Solution
{
    public string Tree2str(TreeNode t)
    {
        return traverse(t);

    }

    private string traverse(TreeNode t)
    {
        if (t == null)
        {
            return "";
        }

        StringBuilder st = new StringBuilder(t.val.ToString());

        if (t.left != null || t.right != null)
        {
            st.AppendFormat("({0})", traverse(t.left));

            if (t.right != null)
            {
                st.AppendFormat("({0})", traverse(t.right));
            }

        }

        return st.ToString();
    }
}