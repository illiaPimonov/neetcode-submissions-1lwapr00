class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        n = len(nums)
        x = 0 

        for i in range(len(nums) + 1):
            x ^= i
        for v in nums:
            x ^= v
        return x

