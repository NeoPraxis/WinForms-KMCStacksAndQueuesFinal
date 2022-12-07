using System;
using System.Windows.Forms;

namespace KMCStacksAndQueuesFinal
{
    public partial class FormStacksAndQueues : Form
    {

        public FormStacksAndQueues()
        {
            InitializeComponent();
        }



        #region data
        #endregion data

        #region properties
        Random random = new Random();

        KMCQueue numberQueue = new KMCQueue();     // queue of waiting customers

        KMCStack numberStack = new KMCStack();
        #endregion properties

        #region queue

        #region methods

        /// <summary>
        /// This routine displays the desired queue in the desired listbox
        /// </summary>
        /// <param name="theQueue"></param>
        /// <param name="theListBox"></param>
        private void DisplayQueue(KMCQueue theQueue, ListBox theListBox)
        {
            // clear the queue
            theListBox.Items.Clear();

            // display header
            theListBox.Items.Add("Front of the Queue");

            // display the content of the queue
            foreach (String randomNumber in theQueue)
            {

                theListBox.Items.Add(randomNumber);
            }

            // display footer
            theListBox.Items.Add("Back of the Queue");

            // display stats
            theListBox.Items.Add(String.Empty);
            theListBox.Items.Add(String.Format("Count = {0}", theQueue.Count));
        }
        #endregion methods

        #region events

        /// <summary>
        /// When the user clicks the enqueue button, create a random number and
        /// add it to the queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            // generate the new random number
            int randomNumber = random.Next(1, 1001);
            String numberString = randomNumber.ToString();
            numberQueue.Enqueue(numberString);

            // display the results
            DisplayQueue(numberQueue, listBoxQueue);
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {

            // Dequeue the front most value of the queue
            numberQueue.Dequeue();

            // display the results
            DisplayQueue(numberQueue, listBoxQueue);
        }

        /// <summary>
        /// This button clears the queue completely
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearQueue_Click(object sender, EventArgs e)
        {

            while (numberQueue != null)
            {
                if (numberQueue.Count > 0)
                {
                    numberQueue.Dequeue();
                    listBoxQueue.Items.Clear();
                }
                else
                {
                    listBoxQueue.Items.Clear();
                    break;
                }

            }
            MessageBox.Show("Cleared Queue");
        }
        /// <summary>
        /// This button transfers a single item from the queue, to the stack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransferToStack_Click(object sender, EventArgs e)
        {
            if (numberQueue.Count != 0)
            {
                numberStack.Push(numberQueue.Dequeue());
                DisplayStack(numberStack, listBoxStack);
                DisplayQueue(numberQueue, listBoxQueue);
            }
        }
        /// <summary>
        /// This button transfers all the items from the queue to the stack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransferAllToStack_Click(object sender, EventArgs e)
        {
            // While the stack is not empty
            while (numberQueue != null)
            {
                // if the count of numbers is greater than 0, pop until empty
                if (numberQueue.Count > 0)
                {
                    numberStack.Push(numberQueue.Dequeue());
                    DisplayStack(numberStack, listBoxStack);
                    DisplayQueue(numberQueue, listBoxQueue);
                    //listBoxStack.Items.Clear();
                }
                else
                {
                    break;
                }
            }
        }
        #endregion events
        #endregion queue

        #region stack
        #region methods
        /// <summary>
        /// This method displays the data for the current stack
        /// </summary>
        /// <param name="theStack"></param>
        /// <param name="theListBox"></param>
        private void DisplayStack(KMCStack theStack, ListBox theListBox)
        {
            // clear the queue
            theListBox.Items.Clear();

            // display header
            theListBox.Items.Add("Top Of the Stack");

            // display the content of the queue
            foreach (String randomNumber in theStack)
            {
                theListBox.Items.Add(randomNumber);
            }

            // display footer
            theListBox.Items.Add("Bottom of the Stack");

            // display stats
            theListBox.Items.Add(String.Empty);
            theListBox.Items.Add(String.Format("Count = {0}", theStack.Count));
        }
        #endregion methods

        #region events
        /// <summary>
        /// This button pushes a new random number to the TOP of the stack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPush_Click(object sender, EventArgs e)
        {
            // generate the new random number
            int randomNumber = random.Next(1, 1001);
            String numberString = randomNumber.ToString();
            // add a number to the top of the stack
            numberStack.Push(numberString);

            // display the results
            DisplayStack(numberStack, listBoxStack);
        }
        /// <summary>
        /// This button pops the TOP number on the stack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPop_Click(object sender, EventArgs e)
        {
            // Pop the top item, and refresh the stack
            numberStack.Pop();
            DisplayStack(numberStack, listBoxStack);
        }
        /// <summary>
        /// This button clears the entire stack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearStack_Click(object sender, EventArgs e)
        {
            // While the stack is not empty
            while (numberStack != null)
            {
                // if the count of numbers is greater than 0, pop until empty
                if (numberStack.Count > 0)
                {
                    numberStack.Pop();
                    listBoxStack.Items.Clear();
                }
                else
                {
                    listBoxStack.Items.Clear();
                    break;
                }

            }
            MessageBox.Show("Cleared Stack");
        }
        /// <summary>
        /// This button transfers a single item from the stack, to the queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransferToQueue_Click(object sender, EventArgs e)
        {
            if (numberStack.Count != 0)
            {
                numberQueue.Enqueue(numberStack.Pop());
                DisplayStack(numberStack, listBoxStack);
                DisplayQueue(numberQueue, listBoxQueue);
            }

        }
        /// <summary>
        /// This button transfers all stack items to the queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTransferAllToQueue_Click(object sender, EventArgs e)
        {

            // While the stack is not empty
            while (numberStack != null)
            {
                // if the count of numbers is greater than 0, pop until empty
                if (numberStack.Count > 0)
                {
                    numberQueue.Enqueue(numberStack.Pop());
                    DisplayStack(numberStack, listBoxStack);
                    DisplayQueue(numberQueue, listBoxQueue);
                    //listBoxStack.Items.Clear();
                }
                else
                {
                    break;
                }

            }
        }
        #endregion events

        #endregion stack

    }
}
