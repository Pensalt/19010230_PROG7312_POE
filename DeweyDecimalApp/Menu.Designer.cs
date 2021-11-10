namespace DeweyDecimalApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnReplacingBooks.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplacingBooks.Location = new System.Drawing.Point(38, 325);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(201, 90);
            this.btnReplacingBooks.TabIndex = 0;
            this.btnReplacingBooks.Text = "Replacing Books";
            this.btnReplacingBooks.UseVisualStyleBackColor = false;
            this.btnReplacingBooks.Click += new System.EventHandler(this.btnReplacingBooks_Click);
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnIdentifyingAreas.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(307, 325);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(201, 90);
            this.btnIdentifyingAreas.TabIndex = 1;
            this.btnIdentifyingAreas.Text = "Identifying Areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = false;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFindingCallNumbers.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(559, 325);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(201, 90);
            this.btnFindingCallNumbers.TabIndex = 2;
            this.btnFindingCallNumbers.Text = "Finding Call Numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = false;
            this.btnFindingCallNumbers.Click += new System.EventHandler(this.btnFindingCallNumbers_Click);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(31, 20);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(729, 41);
            this.lblAppTitle.TabIndex = 3;
            this.lblAppTitle.Text = "Welcome To The Dewey Decimal Game!";
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.Location = new System.Drawing.Point(207, 83);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(405, 33);
            this.lblSubHeading.TabIndex = 4;
            this.lblSubHeading.Text = "What Would You Like To Do?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 156);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(832, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.btnFindingCallNumbers);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnReplacingBooks);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Button btnFindingCallNumbers;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

