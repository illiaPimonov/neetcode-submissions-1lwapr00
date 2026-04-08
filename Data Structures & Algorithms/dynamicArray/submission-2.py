class DynamicArray:
    
    def __init__(self, capacity: int):
        self.capacity = capacity
        self.size = 0
        self.arr = [0] * capacity

    def get(self, i: int) -> int:
        if i < 0 or i >= self.size:
            raise ValueError()
        return self.arr[i]

    def set(self, i: int, n: int) -> None:
        if i < 0 or i >= self.size:
            raise ValueError()
        self.arr[i] = n

    def pushback(self, n: int) -> None:
        if self.size == self.capacity:
            self.resize()
        self.arr[self.size] = n
        self.size += 1 

    def popback(self) -> int:
        i = self.size - 1
        tmp = self.arr[i]
        self.arr[i] = 0
        self.size -= 1
        return tmp

    def resize(self) -> None:
        new_capacity = self.capacity * 2
        new_arr = [0] * new_capacity
        for i in range(self.size):
            new_arr[i] = self.arr[i]
        self.arr = new_arr
        self.capacity = new_capacity

    def getSize(self) -> int:
        return self.size
    
    def getCapacity(self) -> int:
        return self.capacity
