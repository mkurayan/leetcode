public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Solution
{
    private int currentVal;
    private int currentCount = 0;
    private int maxCount = 0;
    private int modeCount = 0;
    private int[] modes;

    public int[] findMode(TreeNode root)
    {
        traverseInOrder(root);
        modes = new int[modeCount];
        modeCount = 0;
        currentCount = 0;
        traverseInOrder(root);
        return modes;
    }

    private void traverseInOrder(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        traverseInOrder(root.left);

        handleValue(root.val);

        traverseInOrder(root.right);
    }

    private void handleValue(int val)
    {
        if (val != currentVal)
        {
            currentVal = val;
            currentCount = 0;
        }
        currentCount++;
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            modeCount = 1;
        }
        else if (currentCount == maxCount)
        {
            if (modes != null)
                modes[modeCount] = currentVal;
            modeCount++;
        }
    }
}