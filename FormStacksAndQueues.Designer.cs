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
            this.buttonTransferToStack = new System.Windows.Forms.Button();
            this.buttonTransferToQueue = new System.Windows.Forms.Button();
            this.buttonTransferAllToStack = new System.Windows.Forms.Button();
            this.buttonTransferAllToQueue = new System.Windows.Forms.Button();
            this.buttonOpenFileQueue = new System.Windows.Forms.Button();
            this.buttonOpenFileStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxQueue
            // 
            this.listBoxQueue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.ItemHeight = 20;
            this.listBoxQueue.Location = new System.Drawing.Point(92, 115);
            this.listBoxQueue.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.Size = new System.Drawing.Size(284, 244);
            this.listBoxQueue.TabIndex = 0;
            // 
            // listBoxStack
            // 
            this.listBoxStack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxStack.FormattingEnabled = true;
            this.listBoxStack.ItemHeight = 20;
            this.listBoxStack.Location = new System.Drawing.Point(544, 115);
            this.listBoxStack.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStack.Name = "listBoxStack";
            this.listBoxStack.Size = new System.Drawing.Size(284, 244);
            this.listBoxStack.TabIndex = 1;
            // 
            // labelQueue
            // 
            this.labelQueue.AutoSize = true;
            this.labelQueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelQueue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelQueue.Location = new System.Drawing.Point(182, 93);
            this.labelQueue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQueue.Name = "labelQueue";
            this.labelQueue.Size = new System.Drawing.Size(98, 22);
            this.labelQueue.TabIndex = 2;
            this.labelQueue.Text = "Queue Data";
            // 
            // labelStack
            // 
            this.labelStack.AutoSize = true;
            this.labelStack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStack.Location = new System.Drawing.Point(646, 93);
            this.labelStack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStack.Name = "labelStack";
            this.labelStack.Size = new System.Drawing.Size(91, 22);
            this.labelStack.TabIndex = 3;
            this.labelStack.Text = "Stack Data";
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEnqueue.Location = new System.Drawing.Point(18, 115);
            this.buttonEnqueue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.Size = new System.Drawing.Size(69, 49);
            this.buttonEnqueue.TabIndex = 4;
            this.buttonEnqueue.Text = "Add";
            this.buttonEnqueue.UseVisualStyleBackColor = false;
            this.buttonEnqueue.Click += new System.EventHandler(this.buttonEnqueue_Click);
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDequeue.Location = new System.Drawing.Point(18, 169);
            this.buttonDequeue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(69, 49);
            this.buttonDequeue.TabIndex = 5;
            this.buttonDequeue.Text = "Delete";
            this.buttonDequeue.UseVisualStyleBackColor = false;
            this.buttonDequeue.Click += new System.EventHandler(this.buttonDequeue_Click);
            // 
            // buttonClearQueue
            // 
            this.buttonClearQueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearQueue.Location = new System.Drawing.Point(18, 309);
            this.buttonClearQueue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearQueue.Name = "buttonClearQueue";
            this.buttonClearQueue.Size = new System.Drawing.Size(69, 49);
            this.buttonClearQueue.TabIndex = 6;
            this.buttonClearQueue.Text = "Clear All";
            this.buttonClearQueue.UseVisualStyleBackColor = false;
            this.buttonClearQueue.Click += new System.EventHandler(this.buttonClearQueue_Click);
            // 
            // buttonClearStack
            // 
            this.buttonClearStack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearStack.Location = new System.Drawing.Point(832, 309);
            this.buttonClearStack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearStack.Name = "buttonClearStack";
            this.buttonClearStack.Size = new System.Drawing.Size(69, 49);
            this.buttonClearStack.TabIndex = 9;
            this.buttonClearStack.Text = "Clear All";
            this.buttonClearStack.UseVisualStyleBackColor = false;
            this.buttonClearStack.Click += new System.EventHandler(this.buttonClearStack_Click);
            // 
            // buttonPop
            // 
            this.buttonPop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPop.Location = new System.Drawing.Point(832, 169);
            this.buttonPop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(69, 49);
            this.buttonPop.TabIndex = 8;
            this.buttonPop.Text = "Delete";
            this.buttonPop.UseVisualStyleBackColor = false;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPush.Location = new System.Drawing.Point(832, 115);
            this.buttonPush.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(69, 49);
            this.buttonPush.TabIndex = 7;
            this.buttonPush.Text = "Add";
            this.buttonPush.UseVisualStyleBackColor = false;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonTransferToStack
            // 
            this.buttonTransferToStack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTransferToStack.Location = new System.Drawing.Point(379, 115);
            this.buttonTransferToStack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransferToStack.Name = "buttonTransferToStack";
            this.buttonTransferToStack.Size = new System.Drawing.Size(69, 49);
            this.buttonTransferToStack.TabIndex = 10;
            this.buttonTransferToStack.Text = ">";
            this.buttonTransferToStack.UseVisualStyleBackColor = false;
            this.buttonTransferToStack.Click += new System.EventHandler(this.buttonTransferToStack_Click);
            // 
            // buttonTransferToQueue
            // 
            this.buttonTransferToQueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTransferToQueue.Location = new System.Drawing.Point(471, 256);
            this.buttonTransferToQueue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransferToQueue.Name = "buttonTransferToQueue";
            this.buttonTransferToQueue.Size = new System.Drawing.Size(69, 49);
            this.buttonTransferToQueue.TabIndex = 11;
            this.buttonTransferToQueue.Text = "<";
            this.buttonTransferToQueue.UseVisualStyleBackColor = false;
            this.buttonTransferToQueue.Click += new System.EventHandler(this.buttonTransferToQueue_Click);
            // 
            // buttonTransferAllToStack
            // 
            this.buttonTransferAllToStack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTransferAllToStack.Location = new System.Drawing.Point(379, 169);
            this.buttonTransferAllToStack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransferAllToStack.Name = "buttonTransferAllToStack";
            this.buttonTransferAllToStack.Size = new System.Drawing.Size(69, 49);
            this.buttonTransferAllToStack.TabIndex = 12;
            this.buttonTransferAllToStack.Text = ">>";
            this.buttonTransferAllToStack.UseVisualStyleBackColor = false;
            this.buttonTransferAllToStack.Click += new System.EventHandler(this.buttonTransferAllToStack_Click);
            // 
            // buttonTransferAllToQueue
            // 
            this.buttonTransferAllToQueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTransferAllToQueue.Location = new System.Drawing.Point(471, 309);
            this.buttonTransferAllToQueue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTransferAllToQueue.Name = "buttonTransferAllToQueue";
            this.buttonTransferAllToQueue.Size = new System.Drawing.Size(69, 49);
            this.buttonTransferAllToQueue.TabIndex = 13;
            this.buttonTransferAllToQueue.Text = "<<";
            this.buttonTransferAllToQueue.UseVisualStyleBackColor = false;
            this.buttonTransferAllToQueue.Click += new System.EventHandler(this.buttonTransferAllToQueue_Click);
            // 
            // buttonOpenFileQueue
            // 
            this.buttonOpenFileQueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFileQueue.Location = new System.Drawing.Point(92, 62);
            this.buttonOpenFileQueue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFileQueue.Name = "buttonOpenFileQueue";
            this.buttonOpenFileQueue.Size = new System.Drawing.Size(69, 49);
            this.buttonOpenFileQueue.TabIndex = 14;
            this.buttonOpenFileQueue.Text = "File";
            this.buttonOpenFileQueue.UseVisualStyleBackColor = false;
            this.buttonOpenFileQueue.Click += new System.EventHandler(this.buttonOpenFileQueue_Click);
            // 
            // buttonOpenFileStack
            // 
            this.buttonOpenFileStack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFileStack.Location = new System.Drawing.Point(759, 62);
            this.buttonOpenFileStack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFileStack.Name = "buttonOpenFileStack";
            this.buttonOpenFileStack.Size = new System.Drawing.Size(69, 49);
            this.buttonOpenFileStack.TabIndex = 15;
            this.buttonOpenFileStack.Text = "File";
            this.buttonOpenFileStack.UseVisualStyleBackColor = false;
            this.buttonOpenFileStack.Click += new System.EventHandler(this.buttonOpenFileStack_Click);
            // 
            // FormStacksAndQueues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(916, 444);
            this.Controls.Add(this.buttonOpenFileStack);
            this.Controls.Add(this.buttonOpenFileQueue);
            this.Controls.Add(this.buttonTransferAllToQueue);
            this.Controls.Add(this.buttonTransferAllToStack);
            this.Controls.Add(this.buttonTransferToQueue);
            this.Controls.Add(this.buttonTransferToStack);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStacksAndQueues";
            this.Text = "Stacks and Queues";
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
        private System.Windows.Forms.Button buttonTransferToStack;
        private System.Windows.Forms.Button buttonTransferToQueue;
        private System.Windows.Forms.Button buttonTransferAllToStack;
        private System.Windows.Forms.Button buttonTransferAllToQueue;
        private System.Windows.Forms.Button buttonOpenFileQueue;
        private System.Windows.Forms.Button buttonOpenFileStack;
    }
}

