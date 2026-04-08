public class Solution {
    public int Search(int[] nums, int target) {
        int lowerBound = 0;
        int nElems = nums.Length;
        int upperBound = nElems -1;
        int curIn;
        while(true){
            curIn = (lowerBound + upperBound) / 2;
            if(nums[curIn] == target){
                return curIn;
            }else if(lowerBound > upperBound){
                return -1;
            }else{
                if(nums[curIn] < target){
                    lowerBound = curIn + 1;
                }else{
                    upperBound = curIn -1;
                }
            }
        }

    }
}
