public class Solution {
    public void SortColors(int[] nums) {
        int max = 0;

        for(int i = 0; i < nums.Length;i++)
        {
            if(nums[i] > max){
                max = nums[i];
            }else{
                continue;
            }
        }
        int[] sec = new int[max + 1];

        for(int i = 0;i < sec.Length;i++)
        {
            sec[i] = 0;
        }

        foreach(int n in nums)
        {
            sec[n] += 1;
        }

        int index = 0;

        for(int i = 0;i < sec.Length;i++){
            while(sec[i] > 0){
                nums[index++] = i;
                sec[i]--;
            }
        }
    }
}