namespace KMCStacksAndQueuesFinal
{
    partial class FormStacksAndQueues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxQueue = new System.Windows.Forms.ListBox();
            this.listBoxStack = new System.Windows.Forms.ListBox();
            this.labelQueue = new System.Windows.Forms.Label();
            this.labelStack = new System.Windows.Forms.Label();
            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.buttonClearQueue = new System.Windows.Forms.Button();
            this.buttonClearStack = new System.Windows.Forms.Button();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxQueue
            // 
            this.listBoxQueue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.ItemHeight = 25;
            this.listBoxQueue.Location = new System.Drawing.Point(122, 80);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.Size = new System.Drawing.Size(377, 304);
            this.listBoxQueue.TabIndex = 0;
            // 
            // listBoxStack
            // 
            this.listBoxStack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxStack.FormattingEnabled = true;
            this.listBoxStack.ItemHeight = 25;
            this.listBoxStack.Location = new System.Drawing.Point(726, 80);
            this.listBoxStack.Name = "listBoxStack";
            this.listBoxStack.Size = new System.Drawing.Size(377, 304);
            this.listBoxStack.TabIndex = 1;
            // 
            // labelQueue
            // 
            this.labelQueue.AutoSize = true;
            this.labelQueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelQueue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelQueue.Location = new System.Drawing.Point(135, 52);
            this.labelQueue.Name = "labelQueue";
            this.labelQueue.Size = new System.Drawing.Size(129, 27);
            this.labelQueue.TabIndex = 2;
            this.labelQueue.Text = "Queue Data";
            // 
            // labelStack
            // 
            this.labelStack.AutoSize = true;
            this.labelStack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStack.Location = new System.Drawing.Point(873, 52);
            this.labelStack.Name = "labelStack";
            this.labelStack.Size = new System.Drawing.Size(119, 27);
            this.labelStack.TabIndex = 3;
            this.labelStack.Text = "Stack Data";
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEnqueue.Location = new System.Drawing.Point(20, 80);
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.Size = new System.Drawing.Size(92, 61);
            this.buttonEnqueue.TabIndex = 4;
            this.buttonEnqueue.Text = "Add";
            this.buttonEnqueue.UseVisualStyleBackColor = false;
            this.buttonEnqueue.Click += new System.EventHandler(this.buttonEnqueue_Click);
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDequeue.Location = new System.Drawing.Point(20, 147);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(92, 61);
            this.buttonDequeue.TabIndex = 5;
            this.buttonDequeue.Text = "Delete";
            this.buttonDequeue.UseVisualStyleBackColor = false;
            this.buttonDequeue.Click += new System.EventHandler(this.buttonDequeue_Click);
            // 
            // buttonClearQueue
            // 
            this.buttonClearQueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearQueue.Location = new System.Drawing.Point(20, 323);
            this.buttonClearQueue.Name = "buttonClearQueue";
            this.buttonClearQueue.Size = new System.Drawing.Size(92, 61);
            this.buttonClearQueue.TabIndex = 6;
            this.buttonClearQueue.Text = "Clear All";
            this.buttonClearQueue.UseVisualStyleBackColor = false;
            this.buttonClearQueue.Click += new System.EventHandler(this.buttonClearQueue_Click);
            // 
            // buttonClearStack
            // 
            this.buttonClearStack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearStack.Location = new System.Drawing.Point(1109, 323);
            this.buttonClearStack.Name = "buttonClearStack";
            this.buttonClearStack.Size = new System.Drawing.Size(92, 61);
            this.buttonClearStack.TabIndex = 9;
            this.buttonClearStack.Text = "Clear All";
            this.buttonClearStack.UseVisualStyleBackColor = false;
            // 
            // buttonPop
            // 
            this.buttonPop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPop.Location = new System.Drawing.Point(1109, 147);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(92, 61);
            this.buttonPop.TabIndex = 8;
            this.buttonPop.Text = "Delete";
            this.buttonPop.UseVisualStyleBackColor = false;
            // 
            // buttonPush
            // 
            this.buttonPush.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPush.Location = new System.Drawing.Point(1109, 80);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(92, 61);
            this.buttonPush.TabIndex = 7;
            this.buttonPush.Text = "Add";
            this.buttonPush.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(512, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(628, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 61);
            this.button2.TabIndex = 11;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(512, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 61);
            this.button3.TabIndex = 12;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(628, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 61);
            this.button4.TabIndex = 13;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FormStacksAndQueues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1221, 410);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClearStack);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.buttonClearQueue);
            this.Controls.Add(this.buttonDequeue);
            this.Controls.Add(this.buttonEnqueue);
            this.Controls.Add(this.labelStack);
            this.Controls.Add(this.labelQueue);
            this.Controls.Add(this.listBoxStack);
            this.Controls.Add(this.listBoxQueue);
            this.Name = "FormStacksAndQueues";
            this.Text = "Stacks and Queues";
            this.Load += new System.EventHandler(this.FormStacksAndQueues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQueue;
        private System.Windows.Forms.ListBox listBoxStack;
        private System.Windows.Forms.Label labelQueue;
        private System.Windows.Forms.Label labelStack;
        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.Button buttonDequeue;
        private System.Windows.Forms.Button buttonClearQueue;
        private System.Windows.Forms.Button buttonClearStack;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

