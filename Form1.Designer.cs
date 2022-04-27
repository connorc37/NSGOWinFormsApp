namespace NSGOWinFormsApp
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnClearLB1 = new System.Windows.Forms.Button();
            this.btnGetSubtitles = new System.Windows.Forms.Button();
            this.btnClearRTB1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(385, 394);
            this.listBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(403, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 394);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chronological",
            "Random",
            "Alphabetical"});
            this.comboBox1.Location = new System.Drawing.Point(192, 415);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 415);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnClearLB1
            // 
            this.btnClearLB1.Location = new System.Drawing.Point(93, 415);
            this.btnClearLB1.Name = "btnClearLB1";
            this.btnClearLB1.Size = new System.Drawing.Size(93, 23);
            this.btnClearLB1.TabIndex = 3;
            this.btnClearLB1.Text = "Clear Selection";
            this.btnClearLB1.UseVisualStyleBackColor = true;
            this.btnClearLB1.Click += new System.EventHandler(this.btnClearLB1_Click);
            // 
            // btnGetSubtitles
            // 
            this.btnGetSubtitles.Location = new System.Drawing.Point(403, 415);
            this.btnGetSubtitles.Name = "btnGetSubtitles";
            this.btnGetSubtitles.Size = new System.Drawing.Size(81, 23);
            this.btnGetSubtitles.TabIndex = 5;
            this.btnGetSubtitles.Text = "Get Subtitles";
            this.btnGetSubtitles.UseVisualStyleBackColor = true;
            this.btnGetSubtitles.Click += new System.EventHandler(this.btnGetSubtitles_Click);
            // 
            // btnClearRTB1
            // 
            this.btnClearRTB1.Location = new System.Drawing.Point(490, 414);
            this.btnClearRTB1.Name = "btnClearRTB1";
            this.btnClearRTB1.Size = new System.Drawing.Size(75, 23);
            this.btnClearRTB1.TabIndex = 6;
            this.btnClearRTB1.Text = "Clear";
            this.btnClearRTB1.UseVisualStyleBackColor = true;
            this.btnClearRTB1.Click += new System.EventHandler(this.btnClearRTB1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(756, 426);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnClearRTB1);
            this.Controls.Add(this.btnGetSubtitles);
            this.Controls.Add(this.btnClearLB1);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Netflix Subtitle Getter/Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Button btnOpenFile;
        private Button btnClearLB1;
        private Button btnGetSubtitles;
        private Button btnClearRTB1;
        private OpenFileDialog openFileDialog1;
        private LinkLabel linkLabel1;
    }
}