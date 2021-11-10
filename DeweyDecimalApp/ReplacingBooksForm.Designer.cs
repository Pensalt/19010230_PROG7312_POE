namespace DeweyDecimalApp
{
    partial class ReplacingBooksForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplacingBooksForm));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRemoveCallNum = new System.Windows.Forms.Button();
            this.btnAddCallNum = new System.Windows.Forms.Button();
            this.lstOriginalList = new System.Windows.Forms.ListBox();
            this.lstUserAnswer = new System.Windows.Forms.ListBox();
            this.lblYourAnswer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOriginalList = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.toolTipReplaceBooks = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(855, 635);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 76);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm Answer";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRemoveCallNum
            // 
            this.btnRemoveCallNum.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRemoveCallNum.Enabled = false;
            this.btnRemoveCallNum.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCallNum.Location = new System.Drawing.Point(440, 484);
            this.btnRemoveCallNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveCallNum.Name = "btnRemoveCallNum";
            this.btnRemoveCallNum.Size = new System.Drawing.Size(156, 59);
            this.btnRemoveCallNum.TabIndex = 15;
            this.btnRemoveCallNum.Text = "Remove";
            this.toolTipReplaceBooks.SetToolTip(this.btnRemoveCallNum, "Click here to remove a call number from your list of sorted call numbers.");
            this.btnRemoveCallNum.UseVisualStyleBackColor = false;
            this.btnRemoveCallNum.Click += new System.EventHandler(this.btnRemoveCallNum_Click);
            // 
            // btnAddCallNum
            // 
            this.btnAddCallNum.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAddCallNum.Enabled = false;
            this.btnAddCallNum.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCallNum.Location = new System.Drawing.Point(440, 389);
            this.btnAddCallNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCallNum.Name = "btnAddCallNum";
            this.btnAddCallNum.Size = new System.Drawing.Size(156, 59);
            this.btnAddCallNum.TabIndex = 14;
            this.btnAddCallNum.Text = "Add";
            this.toolTipReplaceBooks.SetToolTip(this.btnAddCallNum, "Click here to add a call number from the unosorted list to your list of sorted ca" +
        "ll numbers.");
            this.btnAddCallNum.UseVisualStyleBackColor = false;
            this.btnAddCallNum.Click += new System.EventHandler(this.btnAddCallNum_Click);
            // 
            // lstOriginalList
            // 
            this.lstOriginalList.BackColor = System.Drawing.Color.Honeydew;
            this.lstOriginalList.Font = new System.Drawing.Font("Consolas", 11F);
            this.lstOriginalList.FormattingEnabled = true;
            this.lstOriginalList.ItemHeight = 26;
            this.lstOriginalList.Location = new System.Drawing.Point(98, 330);
            this.lstOriginalList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstOriginalList.Name = "lstOriginalList";
            this.lstOriginalList.Size = new System.Drawing.Size(317, 290);
            this.lstOriginalList.TabIndex = 13;
            this.lstOriginalList.SelectedIndexChanged += new System.EventHandler(this.lstOriginalList_SelectedIndexChanged);
            // 
            // lstUserAnswer
            // 
            this.lstUserAnswer.BackColor = System.Drawing.Color.Honeydew;
            this.lstUserAnswer.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUserAnswer.FormattingEnabled = true;
            this.lstUserAnswer.ItemHeight = 26;
            this.lstUserAnswer.Location = new System.Drawing.Point(624, 330);
            this.lstUserAnswer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstUserAnswer.Name = "lstUserAnswer";
            this.lstUserAnswer.Size = new System.Drawing.Size(313, 290);
            this.lstUserAnswer.TabIndex = 12;
            this.lstUserAnswer.SelectedIndexChanged += new System.EventHandler(this.lstUserAnswer_SelectedIndexChanged);
            // 
            // lblYourAnswer
            // 
            this.lblYourAnswer.AutoSize = true;
            this.lblYourAnswer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAnswer.Location = new System.Drawing.Point(670, 285);
            this.lblYourAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourAnswer.Name = "lblYourAnswer";
            this.lblYourAnswer.Size = new System.Drawing.Size(155, 28);
            this.lblYourAnswer.TabIndex = 11;
            this.lblYourAnswer.Text = "Your Answer";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Salmon;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(20, 643);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 68);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblOriginalList
            // 
            this.lblOriginalList.AutoSize = true;
            this.lblOriginalList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalList.Location = new System.Drawing.Point(174, 285);
            this.lblOriginalList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOriginalList.Name = "lblOriginalList";
            this.lblOriginalList.Size = new System.Drawing.Size(181, 28);
            this.lblOriginalList.TabIndex = 9;
            this.lblOriginalList.Text = "Original List";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(624, 201);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 59);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(92, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 33);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Honeydew;
            this.tbName.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(179, 211);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(236, 33);
            this.tbName.TabIndex = 19;
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.Location = new System.Drawing.Point(63, 93);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(900, 33);
            this.lblSubHeading.TabIndex = 21;
            this.lblSubHeading.Text = "Sort The Books in The Fastest Time and Become The Champion!";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(210, 43);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(586, 41);
            this.lblAppTitle.TabIndex = 20;
            this.lblAppTitle.Text = "Welcome To The Sorting Game!";
            // 
            // ReplacingBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1023, 739);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRemoveCallNum);
            this.Controls.Add(this.btnAddCallNum);
            this.Controls.Add(this.lstOriginalList);
            this.Controls.Add(this.lstUserAnswer);
            this.Controls.Add(this.lblYourAnswer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblOriginalList);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplacingBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacing Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRemoveCallNum;
        private System.Windows.Forms.Button btnAddCallNum;
        private System.Windows.Forms.ListBox lstOriginalList;
        private System.Windows.Forms.ListBox lstUserAnswer;
        private System.Windows.Forms.Label lblYourAnswer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOriginalList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.ToolTip toolTipReplaceBooks;
    }
}