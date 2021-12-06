namespace DeweyDecimalApp
{
    partial class FindingCallNumbersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingCallNumbersForm));
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lbAnswers = new System.Windows.Forms.ListBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnSelectAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.Location = new System.Drawing.Point(33, 67);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(705, 33);
            this.lblSubHeading.TabIndex = 23;
            this.lblSubHeading.Text = "Find The Call Numbers and Become The Champion!";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(88, 16);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(589, 41);
            this.lblAppTitle.TabIndex = 22;
            this.lblAppTitle.Text = "Welcome To The Finding Game!";
            // 
            // lbAnswers
            // 
            this.lbAnswers.BackColor = System.Drawing.Color.Honeydew;
            this.lbAnswers.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswers.FormattingEnabled = true;
            this.lbAnswers.HorizontalScrollbar = true;
            this.lbAnswers.ItemHeight = 26;
            this.lbAnswers.Location = new System.Drawing.Point(201, 242);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(438, 186);
            this.lbAnswers.TabIndex = 24;
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.Honeydew;
            this.tbQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuestion.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.Location = new System.Drawing.Point(201, 167);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(438, 31);
            this.tbQuestion.TabIndex = 25;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(27, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 68);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Salmon;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(201, 434);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 68);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(75, 170);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(120, 26);
            this.lblQuestion.TabIndex = 32;
            this.lblQuestion.Text = "Question:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(75, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 26);
            this.lblUsername.TabIndex = 34;
            this.lblUsername.Text = "Username:";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.Honeydew;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(201, 118);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(312, 33);
            this.tbUserName.TabIndex = 33;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFinish.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(483, 434);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(156, 68);
            this.btnFinish.TabIndex = 35;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnSelectAnswer
            // 
            this.btnSelectAnswer.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSelectAnswer.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAnswer.Location = new System.Drawing.Point(656, 283);
            this.btnSelectAnswer.Name = "btnSelectAnswer";
            this.btnSelectAnswer.Size = new System.Drawing.Size(156, 68);
            this.btnSelectAnswer.TabIndex = 36;
            this.btnSelectAnswer.Text = "Select Answer";
            this.btnSelectAnswer.UseVisualStyleBackColor = false;
            this.btnSelectAnswer.Click += new System.EventHandler(this.btnSelectAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Please select the answer below:";
            // 
            // FindingCallNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(839, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectAnswer);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.lbAnswers);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblAppTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindingCallNumbersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindingCallNumbersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.ListBox lbAnswers;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnSelectAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}