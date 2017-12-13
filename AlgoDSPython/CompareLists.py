print("ListA")

def CompareLists(headA,headB):
    if headA is None and headB is None:
        return 1
    else:
        while headA != None:
            if headB == None:
                return 0
            if headA.data != headB.data:
                return 0
            headA = headA.next
            headB = headB.next
    if headB != None:
        return 0
    return 1

class Node:
    def __init__(self, data=None, next_node=None):
        self.data = data
        self.next = next_node


print("ListA")
ListB = Node(data = 1, next_node = Node(data = 2, next_node = Node(data = 3, next_node = Node(data = 4, next_node = None ))))
ListA = Node(data = 1, next_node = Node(data = 2, next_node = Node(data = 3, next_node = Node(data = 4, next_node = Node(data = 5, next_node = None)))))
if CompareLists(ListA,ListB):
    print("Both Lists are Same")
else:
    print("Both Lists are not same")

