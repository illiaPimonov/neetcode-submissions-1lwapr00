class Solution:
    def largestRectangleArea(self, heights: List[int]) -> int:
        maxh = max(heights)
        hlen = len(heights)

        for h in range(hlen):
            width = 0
            minh = heights[h]
            for nh in range(h, hlen):
                width += 1
                if minh > heights[nh]:
                    minh = heights[nh]

                area = minh * width

                if maxh < area:
                    maxh = area

        return maxh