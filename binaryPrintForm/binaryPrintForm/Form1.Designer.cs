namespace binaryPrintForm
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
            this.mainBox = new System.Windows.Forms.PictureBox();
            this.textBoxStringText = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBoxBooleanText = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainBox.Location = new System.Drawing.Point(20, 100);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(1280, 960);
            this.mainBox.TabIndex = 1;
            this.mainBox.TabStop = false;
            // 
            // textBoxStringText
            // 
            this.textBoxStringText.AllowDrop = true;
            this.textBoxStringText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxStringText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStringText.Location = new System.Drawing.Point(1320, 500);
            this.textBoxStringText.MaxLength = 0;
            this.textBoxStringText.Multiline = true;
            this.textBoxStringText.Name = "textBoxStringText";
            this.textBoxStringText.ReadOnly = true;
            this.textBoxStringText.Size = new System.Drawing.Size(580, 250);
            this.textBoxStringText.TabIndex = 2;
            this.textBoxStringText.Text = "textBoxStringText";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(1752, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 23);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1833, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBoxBooleanText
            // 
            this.textBoxBooleanText.AllowDrop = true;
            this.textBoxBooleanText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxBooleanText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBooleanText.Location = new System.Drawing.Point(1320, 100);
            this.textBoxBooleanText.MaxLength = 0;
            this.textBoxBooleanText.Multiline = true;
            this.textBoxBooleanText.Name = "textBoxBooleanText";
            this.textBoxBooleanText.ReadOnly = true;
            this.textBoxBooleanText.Size = new System.Drawing.Size(580, 250);
            this.textBoxBooleanText.TabIndex = 5;
            this.textBoxBooleanText.Text = "textBoxBooleanText";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(1306, 938);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(602, 122);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "DRAW";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1307, 890);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.textBoxBooleanText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.textBoxStringText);
            this.Controls.Add(this.mainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainBox;
        private System.Windows.Forms.TextBox textBoxStringText;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBoxBooleanText;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label1;
    }
}

