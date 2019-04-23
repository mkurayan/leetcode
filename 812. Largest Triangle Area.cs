using System;

public class Solution
{
    public double LargestTriangleArea(int[][] points)
    {
        double maxArea = 0;
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                for (int z = j + 1; z < points.Length; z++)
                {
                    // Shoelace formula
                    double area = Math.Abs(0.5 * ((points[j][0] - points[i][0]) * (points[z][1] - points[i][1]) - (points[z][0] - points[i][0]) * (points[j][1] - points[i][1])));

                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
        }

        return maxArea;
    }
}