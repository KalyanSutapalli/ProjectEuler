using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDS.HackerRank
{
    class LinkedList
    {
        public static int Length(Node head)
        {
            int lengthOfList = 0;
            Node tempHead = head;
            if (tempHead == null)
                return 0;
            else
            {
                while (tempHead != null)
                {
                    tempHead = tempHead.Next;
                    lengthOfList++;
                }
                return lengthOfList;
            }
        }


        public static Node Delete(Node head, int position)
        {
            Node tempHead = head;
            int lengthOfNode = GetLenghthofNode(head);
            //int tempLenght = 0;

            if (lengthOfNode == 0)
            {
                return head;
            }
            else if (lengthOfNode == position)
            {
                while (tempHead.Next == null)
                {
                    tempHead = tempHead.Next;
                }
                tempHead = null;
            }
            else if (position == 0)
            {
                head = tempHead.Next;
            }
            else
            {
                for (int tempLength = 0; tempLength < position - 1; tempLength++)
                {
                    tempHead = tempHead.Next;
                }
                tempHead.Next = tempHead.Next.Next;
            }
            return head;
        }

        public static int GetLenghthofNode(Node tempHead)
        {
            int length = 0;
            while (tempHead != null)
            {
                tempHead = tempHead.Next;
                length++;
            }
            return length;
        }

        public static void ReversePrint(Node head)
        {
            if (head == null) return;
            ReversePrint(head.Next);
            Console.WriteLine(head.Data);
        }


        public static Node finalNode { get; set; }
        public static Node Reverse(Node head)
        {

            if (head == null) return head;

            if (finalNode == null)
                finalNode = new Node { Data = head.Data, Next = null };
            else
                finalNode = new Node { Data = head.Data, Next = finalNode };
            Reverse(head.Next);
            return finalNode;
        }


        public bool CompareLists(Node headA, Node headB)
        {
            while(headA != null && headB != null)
            {
                if (headA.Data != headB.Data)
                    return false;
            }
            return true;
        }


    }


    



    class Node
    {
        public int Data;
        public Node Next;
    }

}
