namespace razor2html
{
    partial class MainForm
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
            this._txtInput = new System.Windows.Forms.TextBox();
            this._btnInBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtUrl = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnOutBrowse = new System.Windows.Forms.Button();
            this._txtOutput = new System.Windows.Forms.TextBox();
            this._btnConvert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtInput
            // 
            this._txtInput.Location = new System.Drawing.Point(112, 17);
            this._txtInput.Name = "_txtInput";
            this._txtInput.Size = new System.Drawing.Size(175, 20);
            this._txtInput.TabIndex = 0;
            this._txtInput.TextChanged += new System.EventHandler(this._txtInput_TextChanged);
            // 
            // _btnInBrowse
            // 
            this._btnInBrowse.Location = new System.Drawing.Point(424, 15);
            this._btnInBrowse.Name = "_btnInBrowse";
            this._btnInBrowse.Size = new System.Drawing.Size(75, 23);
            this._btnInBrowse.TabIndex = 1;
            this._btnInBrowse.Text = "Browse";
            this._btnInBrowse.UseVisualStyleBackColor = true;
            this._btnInBrowse.Click += new System.EventHandler(this._inBrowseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(293, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "I.e. c:\\projects\\mySite\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razor Site Url:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Html Project Folder:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtUrl);
            this.groupBox1.Controls.Add(this._txtInput);
            this.groupBox1.Controls.Add(this._btnInBrowse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(293, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "I.e. http://localhost:8813/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Razor Project Folder:";
            // 
            // _txtUrl
            // 
            this._txtUrl.Location = new System.Drawing.Point(112, 48);
            this._txtUrl.Name = "_txtUrl";
            this._txtUrl.Size = new System.Drawing.Size(175, 20);
            this._txtUrl.TabIndex = 4;
            this._txtUrl.TextChanged += new System.EventHandler(this._txtUrl_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnOutBrowse);
            this.groupBox2.Controls.Add(this._txtOutput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // _btnOutBrowse
            // 
            this._btnOutBrowse.Location = new System.Drawing.Point(424, 19);
            this._btnOutBrowse.Name = "_btnOutBrowse";
            this._btnOutBrowse.Size = new System.Drawing.Size(75, 23);
            this._btnOutBrowse.TabIndex = 6;
            this._btnOutBrowse.Text = "Browse";
            this._btnOutBrowse.UseVisualStyleBackColor = true;
            this._btnOutBrowse.Click += new System.EventHandler(this._outBrowseBtn_Click);
            // 
            // _txtOutput
            // 
            this._txtOutput.Location = new System.Drawing.Point(112, 19);
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.Size = new System.Drawing.Size(306, 20);
            this._txtOutput.TabIndex = 5;
            this._txtOutput.TextChanged += new System.EventHandler(this._txtOutput_TextChanged);
            // 
            // _btnConvert
            // 
            this._btnConvert.Location = new System.Drawing.Point(446, 376);
            this._btnConvert.Name = "_btnConvert";
            this._btnConvert.Size = new System.Drawing.Size(75, 23);
            this._btnConvert.TabIndex = 7;
            this._btnConvert.Text = "Convert";
            this._btnConvert.UseVisualStyleBackColor = true;
            this._btnConvert.Click += new System.EventHandler(this._btnConvert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._txtLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 202);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // _txtLog
            // 
            this._txtLog.Location = new System.Drawing.Point(7, 20);
            this._txtLog.Name = "_txtLog";
            this._txtLog.Size = new System.Drawing.Size(488, 158);
            this._txtLog.TabIndex = 0;
            this._txtLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this._btnConvert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "razor2html";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _txtInput;
        private System.Windows.Forms.Button _btnInBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _btnOutBrowse;
        private System.Windows.Forms.TextBox _txtOutput;
        private System.Windows.Forms.Button _btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox _txtLog;

    }
}

