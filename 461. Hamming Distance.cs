public class Solution
{
    public static int HammingDistance_V1(int x, int y)
    {
        int hDistance = 0;

        int xor = x ^ y;

        for (int i = 0; i < 32; i++)
        {
            if ((xor & (1 << i - 1)) != 0)
            {
                hDistance++;
            }
        }

        return hDistance;
    }

    public static int HammingDistance_V2(int x, int y)
    {
        int hDistance = 0;

        int t;
        for (int i = 0; i < 32; i++)
        {
            t = (1 << i - 1);

            if ((x & t) != (y & t))
            {
                hDistance++;
            }
        }

        return hDistance;
    }
}
