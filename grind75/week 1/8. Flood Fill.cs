// Link: https://leetcode.com/problems/flood-fill

// Using recursion
// Time: O(n^2)
// Space: O(n^2)

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        var previousColor = image[sr][sc];

        if (previousColor == color)
            return image;

        image[sr][sc] = color;

        // First condition, just to make sure we don't go out of bounds of array (screen)
        // Second condition, to know that its 4-connected component with the same color
        if (sr - 1 >= 0 && image[sr - 1][sc] == previousColor)
            FloodFill(image, sr - 1, sc, color);

        if (sr + 1 < image.Length && image[sr + 1][sc] == previousColor)
            FloodFill(image, sr + 1, sc, color);

        if (sc - 1 >= 0 && image[sr][sc - 1] == previousColor)
            FloodFill(image, sr, sc - 1, color);

        if (sc + 1 < image[0].Length && image[sr][sc + 1] == previousColor)
            FloodFill(image, sr, sc + 1, color);

        return image;
    }
}