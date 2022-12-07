using System;
using System.Windows.Forms;

namespace KMCStacksAndQueuesFinal
{
    public partial class FormStacksAndQueues : Form
    {
        Random random = new Random();

        KMCQueue numberQueue = new KMCQueue();     // queue of waiting customers

        KMCStack numberStack = new KMCStack();

        public FormStacksAndQueues()
        {
            InitializeComponent();
        }
        #region queue

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

        #endregion queue

        #region stack

        private void buttonPush_Click(object sender, EventArgs e)
        {
            // generate the new random number
            int randomNumber = random.Next(1, 1001);
            String numberString = randomNumber.ToString();
            numberStack.Push(numberString);

            // display the results
            DisplayStack(numberStack, listBoxStack);
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            numberStack.Pop();
            DisplayStack(numberStack, listBoxStack);
        }

        private void buttonClearStack_Click(object sender, EventArgs e)
        {

            while (numberStack != null)
            {
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
        #endregion stack

    }
}
