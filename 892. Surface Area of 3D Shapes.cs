using System;

public class Solution
{
    int N;

    public int SurfaceArea(int[][] grid)
    {

        N = grid[0].Length;

        int surfaceArea = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (grid[i][j] > 0)
                {
                    int area = grid[i][j] * 4 + 2;

                    if (inGrid(i - 1, j))
                    {
                        area -= Math.Min(grid[i][j], grid[i - 1][j]);
                    }

                    if (inGrid(i + 1, j))
                    {
                        area -= Math.Min(grid[i][j], grid[i + 1][j]);
                    }

                    if (inGrid(i, j - 1))
                    {
                        area -= Math.Min(grid[i][j], grid[i][j - 1]);
                    }

                    if (inGrid(i, j + 1))
                    {
                        area -= Math.Min(grid[i][j], grid[i][j + 1]);
                    }

                    surfaceArea += area;
                }


            }
        }

        return surfaceArea;
    }

    private bool inGrid(int i, int j)
    {
        return (0 <= i && i < N) && (0 <= j && j < N);
    }
}