using System.Text;

public class Solution
{
    public string RemoveOuterParentheses(string S)
    {
        if (S == null || S.Length == 0)
        {
            return "";
        }

        StringBuilder decomposition = new StringBuilder();

        int counter = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == '(')
            {
                counter++;

                if (counter > 1)
                {
                    decomposition.Append(S[i]);
                }
            }
            else
            {
                counter--;

                if (counter > 0)
                {
                    decomposition.Append(S[i]);
                }
            }
        }

        return decomposition.ToString();
    }
}