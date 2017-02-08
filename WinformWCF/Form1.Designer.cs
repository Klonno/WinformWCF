namespace WinformWCF
{
    partial class Form1
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
            this.blinkButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.callServiceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blinkButton
            // 
            this.blinkButton.AutoSize = true;
            this.blinkButton.Location = new System.Drawing.Point(215, 24);
            this.blinkButton.Name = "blinkButton";
            this.blinkButton.Size = new System.Drawing.Size(87, 17);
            this.blinkButton.TabIndex = 0;
            this.blinkButton.TabStop = true;
            this.blinkButton.Text = "I should blink";
            this.blinkButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stop Blinking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // callServiceButton
            // 
            this.callServiceButton.Location = new System.Drawing.Point(12, 206);
            this.callServiceButton.Name = "callServiceButton";
            this.callServiceButton.Size = new System.Drawing.Size(174, 23);
            this.callServiceButton.TabIndex = 2;
            this.callServiceButton.Text = "Call Test WCF Service";
            this.callServiceButton.UseVisualStyleBackColor = true;
            this.callServiceButton.Click += new System.EventHandler(this.callServiceButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "An instance of IIS express  will start (if not already running) supporting  the W" +
    "CFService API at http://localhost:16371/. The URL is specified as an endpoint in" +
    " the app.config file.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.callServiceButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blinkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton blinkButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button callServiceButton;
        private System.Windows.Forms.Label label1;
    }
}

