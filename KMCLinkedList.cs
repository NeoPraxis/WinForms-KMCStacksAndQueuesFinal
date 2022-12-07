/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMCStacksAndQueuesFinal
{
    internal class KMCLinkedList
    {


        #region data
        #endregion data

        #region properties
        public KMCNode Top { get; set; }    // pointer top of link list

        public int count;                    // initialize count
        #endregion properties

        #region constructor
        public KMCLinkedList()
        {
            Top = null;
            count = 0;                      // set count to 0
        }
        #endregion constructor

        #region methods
        /// <summary>
        /// This function adds a customer at the beginning of
        /// the link list.
        /// </summary>
        /// <param name="lastname">Customer name</param>
        public void AddAtBeginning(String lastname)
        {
            // create a new node for the customer
            KMCNode customer = new KMCNode(lastname);

            // add the cutomer to the front of the list
            customer.Next = Top;
            Top = customer;
            count++;
        }

        /// <summary>
        /// This function adds a customer at the end of the 
        /// link list
        /// </summary>
        /// <param name="lastname">Customer name</param>
        public void AddAtEnd(String lastname)
        {
            // create a new node for the customer
            KMCNode customer = new KMCNode(lastname);

            // special case - empty list
            if (Top is null)
            {
                Top = customer;
            }
            else
            {
                // non-empty list, walk down to find the end
                KMCNode current = Top;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // found the end, insert here
                current.Next = customer;
            }
            count++;
        }

        /// <summary>
        /// This function will delete the first node in the list no matter the value
        /// </summary>
        public void DeleteFirst()
        {
            // to prevent an error, do nothing on an empty list
            if (Top == null)
            {
                return;
            }
            // uses the delete method to delete the top-most node, while also checking for next
            DeleteNode(Top, null);
            count--;
        }
        /// <summary>
        /// This function will delete the last node with any value in the link list
        /// </summary>
        public void DeleteLast()
        {
            // to prevent an error, do nothing on an empty list
            if (Top == null)
            {
                return;
            }

            // create a temp node, nodeToDelete
            KMCNode nodeToDelete = Top, previous = null;

            while (nodeToDelete.Next != null)
            {
                previous = nodeToDelete;
                nodeToDelete = nodeToDelete.Next;
            }
            DeleteNode(nodeToDelete, previous);
            count--;
        }*//*
        /// <summary>
        /// This method counts by traversing the list
        /// </summary>
        /// <returns></returns>
        public int CountByTraversal()
        {
            int nodeCount = 0;
            KMC_Node currentNode = Top;
            while (currentNode != null)
            {
                nodeCount++;
                currentNode = currentNode.Next;
            }
            return nodeCount;
        }*//*

        #endregion methods
        #region private methods
        /// <summary>
        /// This method will be used by other public methods to delete a node in the link list
        /// </summary>
        /// <param name="nodeToDelete"></param>
        private void DeleteNode(KMCNode nodeToDelete, KMCNode previous)
        {
            // if nodeToDelete is first node
            if (nodeToDelete == Top)
            {
                // set top to null (removing the first node)
                Top = null;

                // set next node to top, IF node exists
                if (nodeToDelete.Next != null)
                {
                    Top = nodeToDelete.Next;
                }
            }
            // if nodeToDelete is NOT first node, then previous exists
            else
            {
                // deletes current node
                previous.Next = null;

                // set next, IF node exists
                if (nodeToDelete.Next != null)
                {
                    previous.Next = nodeToDelete.Next;
                }
            }
        }
        #endregion private methods
    }
}
*/