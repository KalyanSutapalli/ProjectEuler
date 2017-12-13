def Reverse(head):
    if head is None:
        return None
    prev = None
    curr = head
    aux = head.next
    while curr is not None:
        curr.next = prev
        prev = curr
        curr = aux
        if curr is not None:
            aux = aux.next
    return prev


