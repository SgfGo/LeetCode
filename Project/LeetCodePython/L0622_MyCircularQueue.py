# @Time    : 2021-03-02 23:27
# @Author  : SgfGo
# @FileName: MyCircularQueue.py
# @Software: PyCharm
# @GitHub ：https://github.com/SgfGo/LeetCode
# @LeetCode : https://leetcode-cn.com/problems/design-circular-queue/

class MyCircularQueue:
    # 初始化队列
    def __init__(self, k: int):
        self.items = []
        self.maxLenth = k

    def enQueue(self, value: int) -> bool:
        if len(self.items) >= self.maxLenth:
            return False
        self.items.insert(0,value)
        return True

    def deQueue(self) -> bool:
        if len(self.items) <= 0:
            return False
        self.items.pop()
        return True

    def Front(self) -> int:
        if len(self.items) <= 0:
            return -1
        return self.items[len(self.items) - 1]

    def Rear(self) -> int:
        if len(self.items) <= 0:
            return -1
        return self.items[0]

    def isEmpty(self) -> bool:
        return self.items == []

    def isFull(self) -> bool:
        return len(self.items) == self.maxLenth

# runtime：92ms
# memory：15.3mb