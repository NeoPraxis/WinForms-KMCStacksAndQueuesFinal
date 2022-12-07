/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KMCStacksAndQueuesFinal
{
    internal class KMCStack
    {
        #region data
        #endregion data

        #region properties
        Random random = new Random();

        //int randomNumberToAdd;
        //private Random randomNumber
        //int randomNumber = random.Next(1, 1001);

        public int Count { get; private set; }      // number of cards in the current stack
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
        public void Push()
        {
            // push the playing card onto the top of the stack
            if (IsEmpty())
            {
                // stack is empty
                Top = oneCard;
                oneCard.Next = null;
            }
            else
            {
                // place on top
                oneCard.Next = Top;
                Top = oneCard;
            }
            // increment the count of cards
            Count++;
        }


        /// <summary>
        /// This routine returns the top card from the stack without removing it
        /// </summary>
        /// <returns>Top card on the stack if it exists</returns>
        public KMCPLayingCard Peep()
        {
            if (!IsEmpty())
            {
                return null;
            }
            else
            {
                return Top;
            }


        }

        /// <summary>
        /// This routine will remove the top playing card from the stack and
        /// return it.
        /// </summary>
        /// <returns>Top playing card from the stack if it exists,
        /// otherwise returns null</returns>
        public KMCPLayingCard Pop()
        {
            KMCPLayingCard oneCard = null;

            if (!IsEmpty())
            {
                // remove the card
                oneCard = Top;
                Top = Top.Next;

                // breaks all links to the top card
                oneCard.Next = null;

                // decrement the count
                Count--;


            }
            // return the playing card
            return oneCard;
        }
        #endregion methods

        #region enumerable


        /// <summary>
        /// This method will walk down the link list one at
        /// a time, returning each item to the calling routine.
        /// </summary>
        /// <returns>Playing card each time</returns>
        public IEnumerator<KMCPLayingCard> GetEnumerator()
        {
            // create a node to walk down the list
            KMCPLayingCard current = Top;

            //
            while (current != null)
            {
                // return current playing card
                yield return current;
                current = current.Next;
            }
        }
        // microsoft code behind the scenes
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion enumeruable
    }
}
*/