namespace SCP
{
    partial class SCP
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
            this.storeSCP = new System.Windows.Forms.Button();
            this.portNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.binariesPath = new System.Windows.Forms.TextBox();
            this.binariesPathButton = new System.Windows.Forms.Button();
            this.destinationButton = new System.Windows.Forms.Button();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // storeSCP
            // 
            this.storeSCP.Location = new System.Drawing.Point(15, 107);
            this.storeSCP.Name = "storeSCP";
            this.storeSCP.Size = new System.Drawing.Size(75, 23);
            this.storeSCP.TabIndex = 0;
            this.storeSCP.Text = "StoreSCP";
            this.storeSCP.UseVisualStyleBackColor = true;
            this.storeSCP.Click += new System.EventHandler(this.storeSCP_Click);
            // 
            // portNumber
            // 
            this.portNumber.Location = new System.Drawing.Point(134, 74);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(204, 20);
            this.portNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input port to use";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // outputWindow
            // 
            this.outputWindow.Location = new System.Drawing.Point(15, 136);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputWindow.Size = new System.Drawing.Size(458, 168);
            this.outputWindow.TabIndex = 3;
            // 
            // binariesPath
            // 
            this.binariesPath.Location = new System.Drawing.Point(134, 12);
            this.binariesPath.Name = "binariesPath";
            this.binariesPath.Size = new System.Drawing.Size(302, 20);
            this.binariesPath.TabIndex = 10;
            this.binariesPath.Text = "Select path for DCMTK Binaries";
            // 
            // binariesPathButton
            // 
            this.binariesPathButton.Location = new System.Drawing.Point(12, 13);
            this.binariesPathButton.Name = "binariesPathButton";
            this.binariesPathButton.Size = new System.Drawing.Size(116, 22);
            this.binariesPathButton.TabIndex = 11;
            this.binariesPathButton.Text = "Select Binaries Path";
            this.binariesPathButton.UseVisualStyleBackColor = true;
            this.binariesPathButton.Click += new System.EventHandler(this.binariesPathButton_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(12, 41);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(116, 22);
            this.destinationButton.TabIndex = 12;
            this.destinationButton.Text = "Select Destination";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // destinationText
            // 
            this.destinationText.Location = new System.Drawing.Point(134, 43);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(302, 20);
            this.destinationText.TabIndex = 13;
            this.destinationText.Text = "Select path for file destination";
            // 
            // SCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 316);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.destinationButton);
            this.Controls.Add(this.binariesPathButton);
            this.Controls.Add(this.binariesPath);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNumber);
            this.Controls.Add(this.storeSCP);
            this.Name = "SCP";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button storeSCP;
        private System.Windows.Forms.TextBox portNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputWindow;
        private System.Windows.Forms.TextBox binariesPath;
        private System.Windows.Forms.Button binariesPathButton;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.TextBox destinationText;
    }
}

