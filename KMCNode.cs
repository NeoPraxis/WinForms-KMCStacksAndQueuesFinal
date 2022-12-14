/* ********************************************************************
 * Projct:      Stacks and Queues Final
 * File:        KMCNode.cs
 * Language:    C#
 * 
 * Desription:  This class is a node that uses pointers for linked lists
 *              
 * College:     Husson University
 * Course:      IT 325
 * 
 * Edit History:
 * Ver   Who Date       Notes
 * ----- --- ---------- -----------------------------------------------
 * 0.1   KMC 12/02/2022 - initial writing
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMCStacksAndQueuesFinal
{
    internal class KMCNode
    {

        //Random random = new Random();
        #region enum
        #endregion enum

        #region data
        #endregion data

        #region properties
        public String Number { get; set; }      // number that is being used in queue

        public KMCNode Next { get; set; }    // pointer to the next number in the queue

        
        #endregion properties

        #region constructor
        /// <summary>
        /// This routine initializes a Customer Node using the Customer Identifier
        /// </summary>
        /// <param name="number"></param>
        public KMCNode(String number)
        {
            Number = number;
            Next = null;
        }

        #endregion constructor

        #region methods/*
        /// <summary>
        /// This method outputs the node in a generic format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
        return String.Format("{0}", this.Number,
            this.Next == null ? "" : this.Next.Number);
        }
        #endregion methods
    }
}
