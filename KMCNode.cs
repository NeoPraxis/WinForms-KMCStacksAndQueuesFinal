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
        public String Number { get; set; }      // number that is being used
        public KMCNode Next { get; set; }    // pointer to the next customer
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
        return String.Format("Number = {0}, Next = {1}", this.Number,
            this.Next == null ? "end of queue" : this.Next.Number);
        }
        #endregion methods
    }
}
