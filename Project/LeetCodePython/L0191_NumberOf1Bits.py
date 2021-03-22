# @Time    : 2021年03月22日18:46:48
# @Author  : SgfGo
# @FileName: L0191_NumberOf1Bits.py
# @Software: PyCharm
# @GitHub ：https://github.com/SgfGo/LeetCode
# @LeetCode : https://leetcode-cn.com/problems/number-of-1-bits/
# 汉明重量
class Solution:
    def hammingWeight(self, n: int) -> int:
        ans = 0
        if n == 0:
            return 0
        while n > 0:
            print(n)
            n = n & (n - 1)
            ans += 1
        return ans

        # return num1;

so = Solution()
print( so.hammingWeight(0b0000000000000000000000000001011))