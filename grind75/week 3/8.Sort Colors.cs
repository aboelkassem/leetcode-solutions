// Link: https://leetcode.com/problems/sort-colors

// Using Two pass Count
// Time: O(n)
// Space: O(1)
public void SortColors(int[] nums) {
  int[] count = new int[3];

  // Count each color
  foreach (int num in nums) {
    count[num]++;
  }

  int writeInd = 0;

  // Fill in the values
  for (int i = 0; i < 3; i++) {
    while (count[i] > 0) {
      nums[writeInd] = i;
      count[i]--;
      writeInd++;
    }
  }
}

// Using Two pointers (One-pass)
// Time: O(n)
// Space: O(1)
public void SortColors(int[] nums) {
  int zero = 0;
  int one = 0;
  int two = nums.Length - 1;

  while (one <= two) {
    switch (nums[one]) {
    case 0:
      (nums[zero], nums[one]) = (nums[one], nums[zero]); // Swap
      zero++;
      one++;
      break;

    case 1:
      one++;
      break;

    case 2:
      (nums[one], nums[two]) = (nums[two], nums[one]); // Swap
      two--;
      break;
    }
  }
}
