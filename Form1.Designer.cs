namespace HangMan
{
    partial class HangMan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayText = new System.Windows.Forms.Button();
            this.qButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.FailedAttButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.sButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayText
            // 
            this.DisplayText.Location = new System.Drawing.Point(77, 48);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(431, 151);
            this.DisplayText.TabIndex = 0;
            this.DisplayText.Text = "-";
            this.DisplayText.UseVisualStyleBackColor = true;
            // 
            // qButton
            // 
            this.qButton.Location = new System.Drawing.Point(22, 270);
            this.qButton.Name = "qButton";
            this.qButton.Size = new System.Drawing.Size(42, 29);
            this.qButton.TabIndex = 2;
            this.qButton.Text = "q";
            this.qButton.UseVisualStyleBackColor = true;
            this.qButton.Click += new System.EventHandler(this.qButton_Click);
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(46, 319);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(42, 29);
            this.aButton.TabIndex = 3;
            this.aButton.Text = "a";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // FailedAttButton
            // 
            this.FailedAttButton.Location = new System.Drawing.Point(613, 12);
            this.FailedAttButton.Name = "FailedAttButton";
            this.FailedAttButton.Size = new System.Drawing.Size(175, 29);
            this.FailedAttButton.TabIndex = 4;
            this.FailedAttButton.Text = "Wrong Guesses:";
            this.FailedAttButton.UseVisualStyleBackColor = true;
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(175, 319);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(42, 29);
            this.dButton.TabIndex = 5;
            this.dButton.Text = "d";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // sButton
            // 
            this.sButton.Location = new System.Drawing.Point(109, 319);
            this.sButton.Name = "sButton";
            this.sButton.Size = new System.Drawing.Size(42, 29);
            this.sButton.TabIndex = 6;
            this.sButton.Text = "s";
            this.sButton.UseVisualStyleBackColor = true;
            this.sButton.Click += new System.EventHandler(this.sButton_Click);
            // 
            // HangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.FailedAttButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.qButton);
            this.Controls.Add(this.DisplayText);
            this.Name = "HangMan";
            this.Text = "HangMan";
            this.ResumeLayout(false);

        }

        #endregion

        private Button DisplayText;
        public void DisplayToButton(string txt)
        {
            this.DisplayText.Text = txt;
        }

        private Button qButton;
        private Button aButton;
        private Button FailedAttButton;
        private Button dButton;
        private Button sButton;
    }
}