using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KMCStacksAndQueuesFinal
{
    internal class KMCStack : IEnumerable<String>
    {
        #region data
        #endregion data

        #region properties
        public int Count { get; set; }      // number of cards in the current stack

        private KMCNode Top { get; set; }

        #endregion properties

        #region constructor
        /// <summary>
        /// This constructor creates an empty stack of cards.
        /// </summary>
        public KMCStack()
        {
            Top = null;
            Count = 0;
        }
        #endregion constructor

        #region methods
        /// <summary>
        /// This method will clear a stack of all playing cards
        /// </summary>
        public void Clear()
        {
            Top = null;
            Count = 0;
        }

        /// <summary>
        /// This method returns True if the stack is empty
        /// </summary>
        /// <returns>True - if stack is empty
        ///          False - if stack has at least one card</returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// This routine will place the new card at the top of the stack
        /// </summary>
        /// <param name="oneCard"></param>
        public void Push(String number)
        {
            KMCNode selectedNumber = new KMCNode(number);
            // push the playing card onto the top of the stack
            if (IsEmpty())
            {
                // stack is empty
                Top = selectedNumber;
                selectedNumber.Next = null;
            }
            else
            {
                // place on top
                selectedNumber.Next = Top;
                Top = selectedNumber;
            }
            // increment the count of cards
            Count++;
        }

        /// <summary>
        /// This routine will remove the top playing card from the stack and
        /// return it.
        /// </summary>
        /// <returns>Top playing card from the stack if it exists,
        /// otherwise returns null</returns>
        public String Pop()
        {
            String item;

            if (IsEmpty())
            {
                item = null;
            }
            else
            {
                // queue is not empty, return first item
                item = Top.Number;
                Top = Top.Next;
                Count--;
            }
            // return the playing card
            return item;
        }

        #endregion methods

        #region enumerable


        /// <summary>
        /// This method will walk down the link list one at
        /// a time, returning each item to the calling routine.
        /// </summary>
        /// <returns>Playing card each time</returns>
        /// 

        public IEnumerator<String> GetEnumerator()
        {
            // create a node to walk down the list
            KMCNode current = Top;

            //
            while (current != null)
            {
                // return current playing card
                yield return current.ToString();
                current = current.Next;
            }
        }
        // microsoft code behind the scenes
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion enumeruable
    }
}
