public class Solution
{
    public bool IsMonotonic(int[] A)
    {
        if (A.Length < 2) return true;

        bool decreasing = false;
        bool increasing = false;

        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] == A[i - 1])
            {
                continue;
            }

            if (A[i] > A[i - 1])
            {
                increasing = true;

                if (decreasing)
                {
                    return false;
                }
            }
            else
            {
                decreasing = true;

                if (increasing)
                {
                    return false;
                }
            }
        }

        return true;
    }
}