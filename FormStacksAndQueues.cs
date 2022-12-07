using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMCStacksAndQueuesFinal
{
    public partial class FormStacksAndQueues : Form
    {
        Random random = new Random();

        KMCQueue waitingQueue = new KMCQueue();     // queue of waiting customers

        public FormStacksAndQueues()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the user clicks the enqueue button, create a customer id and
        /// add it to the queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            // generate the new customer
            int randomNumber = random.Next(1, 1001);
            String numberString = randomNumber.ToString();
            waitingQueue.Enqueue(numberString);

            // display the results
            DisplayQueue(waitingQueue, listBoxQueue);
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {

            // generate the new customer
            //int randomNumber = random.Next(1, 1001);
            //String numberString = randomNumber.ToString();
            waitingQueue.Dequeue();

            // display the results
            DisplayQueue(waitingQueue, listBoxQueue);
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

        private void FormStacksAndQueues_Load(object sender, EventArgs e)
        {

        }

        private void buttonClearQueue_Click(object sender, EventArgs e)
        {

            while (waitingQueue != null)
            {
                if (waitingQueue.Count > 0)
                {
                    waitingQueue.Dequeue();
                    listBoxQueue.Items.Clear();
                }
                else
                {
                    break;
                }
                
            }
            MessageBox.Show("Cleared Queue");
        }
    }
}
