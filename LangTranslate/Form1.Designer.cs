namespace LangTranslate
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
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.comboAvailableLangs = new System.Windows.Forms.ComboBox();
            this.txtDestlang = new System.Windows.Forms.TextBox();
            this.btnDetectSrcLang = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.lblSrcLang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSrc.Location = new System.Drawing.Point(12, 87);
            this.txtSrc.Multiline = true;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSrc.Size = new System.Drawing.Size(440, 126);
            this.txtSrc.TabIndex = 0;
            this.txtSrc.TextChanged += new System.EventHandler(this.txtSrc_TextChanged);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Location = new System.Drawing.Point(185, 331);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(82, 30);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // comboAvailableLangs
            // 
            this.comboAvailableLangs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAvailableLangs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAvailableLangs.FormattingEnabled = true;
            this.comboAvailableLangs.Location = new System.Drawing.Point(12, 291);
            this.comboAvailableLangs.Name = "comboAvailableLangs";
            this.comboAvailableLangs.Size = new System.Drawing.Size(440, 24);
            this.comboAvailableLangs.TabIndex = 4;
            this.comboAvailableLangs.Text = "<Select language>";
            this.comboAvailableLangs.SelectedIndexChanged += new System.EventHandler(this.comboAvailableLangs_SelectedIndexChanged);
            // 
            // txtDestlang
            // 
            this.txtDestlang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestlang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestlang.Location = new System.Drawing.Point(12, 367);
            this.txtDestlang.Multiline = true;
            this.txtDestlang.Name = "txtDestlang";
            this.txtDestlang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDestlang.Size = new System.Drawing.Size(440, 126);
            this.txtDestlang.TabIndex = 5;
            this.txtDestlang.TextChanged += new System.EventHandler(this.txtDestlang_TextChanged);
            // 
            // btnDetectSrcLang
            // 
            this.btnDetectSrcLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetectSrcLang.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDetectSrcLang.FlatAppearance.BorderSize = 0;
            this.btnDetectSrcLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectSrcLang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDetectSrcLang.Location = new System.Drawing.Point(162, 219);
            this.btnDetectSrcLang.Name = "btnDetectSrcLang";
            this.btnDetectSrcLang.Size = new System.Drawing.Size(141, 30);
            this.btnDetectSrcLang.TabIndex = 7;
            this.btnDetectSrcLang.Text = "Detect Language";
            this.btnDetectSrcLang.UseVisualStyleBackColor = true;
            this.btnDetectSrcLang.Click += new System.EventHandler(this.btnDetectSrcLang_Click);
            // 
            // btnAC
            // 
            this.btnAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAC.FlatAppearance.BorderSize = 0;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Location = new System.Drawing.Point(111, 255);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(236, 30);
            this.btnAC.TabIndex = 8;
            this.btnAC.Text = "Request Available Languages";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // lblSrcLang
            // 
            this.lblSrcLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSrcLang.AutoSize = true;
            this.lblSrcLang.Location = new System.Drawing.Point(9, 496);
            this.lblSrcLang.Name = "lblSrcLang";
            this.lblSrcLang.Size = new System.Drawing.Size(53, 17);
            this.lblSrcLang.TabIndex = 9;
            this.lblSrcLang.Text = "Source";
            this.lblSrcLang.Click += new System.EventHandler(this.lblSrcLang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 28);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Language Translator";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(223, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 17);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Using Azure Translator Api";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(434, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSrcLang);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnDetectSrcLang);
            this.Controls.Add(this.txtDestlang);
            this.Controls.Add(this.comboAvailableLangs);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.ComboBox comboAvailableLangs;
        private System.Windows.Forms.TextBox txtDestlang;
        private System.Windows.Forms.Button btnDetectSrcLang;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Label lblSrcLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}

