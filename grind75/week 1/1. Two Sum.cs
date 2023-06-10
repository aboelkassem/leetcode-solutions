// Brute-Force
// Time: O(n^2)
// Space: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                    result = new int[] { i, j };
            }
        }

        return result;
    }
}


// Optimal Solution using Hash Table
// Time: O(n)
// Space: O(n)

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //Dictionary of previously visited values
        Dictionary<int, int> seen = new Dictionary<int, int>();
    
        for(int i = 0; i < nums.Length; i++){
            //Find the difference
            var diff = target - nums[i];
            //If difference already exists in the dictionary return the indexes of current index and already visited index
            if(seen.ContainsKey(diff)){
                return new []{seen[diff],i};
            }else{
                //Add to the dictionary
                seen[nums[i]] = i;
            }
        }
        return null;
    }
}
