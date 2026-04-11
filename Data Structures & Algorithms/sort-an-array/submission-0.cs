public class Solution {
    public int[] SortArray(int[] nums) {
        int size = nums.Length;
        int h = 1;

        while(h <= size /3){
            h = 3*h + 1;
        }

        while(h>0){
            for(int i = h;i< size;i++){
                int j = i;
                int temp = nums[i];
                while(j>=h && nums[j-h] > temp){
                    nums[j] = nums[j-h];
                    j -=h;
                }
                nums[j] = temp;
            }
            h = (h-1) / 3;
        }
        return nums;
    }
}