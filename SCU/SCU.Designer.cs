namespace SCU
{
    partial class SCU
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
            this.echo = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.selectFileDialog = new System.Windows.Forms.TextBox();
            this.hostName = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.binariesPathButton = new System.Windows.Forms.Button();
            this.binariesPath = new System.Windows.Forms.TextBox();
            this.outputWindow = new System.Windows.Forms.TextBox();
            this.verboseToggle = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // echo
            // 
            this.echo.Location = new System.Drawing.Point(3, 106);
            this.echo.Name = "echo";
            this.echo.Size = new System.Drawing.Size(75, 23);
            this.echo.TabIndex = 0;
            this.echo.Text = "echoSCP";
            this.echo.UseVisualStyleBackColor = true;
            this.echo.Click += new System.EventHandler(this.echo_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(143, 106);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 1;
            this.send.Text = "sendSCP";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // selectFileDialog
            // 
            this.selectFileDialog.Location = new System.Drawing.Point(143, 31);
            this.selectFileDialog.Name = "selectFileDialog";
            this.selectFileDialog.Size = new System.Drawing.Size(302, 20);
            this.selectFileDialog.TabIndex = 2;
            this.selectFileDialog.TextChanged += new System.EventHandler(this.selectFileDialog_TextChanged);
            // 
            // hostName
            // 
            this.hostName.Location = new System.Drawing.Point(143, 55);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(173, 20);
            this.hostName.TabIndex = 3;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(3, 31);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 18);
            this.selectFileButton.TabIndex = 4;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host IP";
            // 
            // portNumber
            // 
            this.portNumber.Location = new System.Drawing.Point(143, 79);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(173, 20);
            this.portNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.send, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.selectFileDialog, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.echo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.selectFileButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.portNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.hostName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.binariesPathButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.binariesPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 142);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // binariesPathButton
            // 
            this.binariesPathButton.Location = new System.Drawing.Point(3, 3);
            this.binariesPathButton.Name = "binariesPathButton";
            this.binariesPathButton.Size = new System.Drawing.Size(116, 22);
            this.binariesPathButton.TabIndex = 8;
            this.binariesPathButton.Text = "Select Binaries Path";
            this.binariesPathButton.UseVisualStyleBackColor = true;
            this.binariesPathButton.Click += new System.EventHandler(this.binariesPathButton_Click);
            // 
            // binariesPath
            // 
            this.binariesPath.Location = new System.Drawing.Point(143, 3);
            this.binariesPath.Name = "binariesPath";
            this.binariesPath.Size = new System.Drawing.Size(302, 20);
            this.binariesPath.TabIndex = 9;
            this.binariesPath.Text = "Select path for DCMTK Binaries";
            // 
            // outputWindow
            // 
            this.outputWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputWindow.Location = new System.Drawing.Point(6, 214);
            this.outputWindow.Multiline = true;
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputWindow.Size = new System.Drawing.Size(445, 233);
            this.outputWindow.TabIndex = 9;
            // 
            // verboseToggle
            // 
            this.verboseToggle.AutoSize = true;
            this.verboseToggle.Location = new System.Drawing.Point(3, 152);
            this.verboseToggle.Name = "verboseToggle";
            this.verboseToggle.Size = new System.Drawing.Size(95, 17);
            this.verboseToggle.TabIndex = 11;
            this.verboseToggle.Text = "Verbose Mode";
            this.verboseToggle.UseVisualStyleBackColor = true;
            // 
            // SCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 459);
            this.Controls.Add(this.verboseToggle);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SCU";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button echo;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox selectFileDialog;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button binariesPathButton;
        private System.Windows.Forms.TextBox binariesPath;
        private System.Windows.Forms.TextBox outputWindow;
        private System.Windows.Forms.CheckBox verboseToggle;
    }
}

