public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int primeter = 0;
        int row = grid.Length, column = grid[0].Length;
        for (int i = 0; i < row; ++i)
        {
            for (int j = 0; j < column; ++j)
            {
                // when the cell is water ignore and continue looping
                if (grid[i][j] == 0)
                    continue;

                // make the default square perimeter = 4
                primeter += 4;

                // subtract the island based on it's position
                if (i > 0)
                    primeter -= grid[i-1][j];
                if (j > 0)
                    primeter -= grid[i][j-1];
                if (i < row-1)
                    primeter -= grid[i+1][j];
                if (j < column-1)
                    primeter -= grid[i][j+1];
            }
        }

        return primeter;
    }
}