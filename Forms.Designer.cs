namespace SpecPro
{
    partial class Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forms));
            this.B_mail = new System.Windows.Forms.Button();
            this.SFD1 = new System.Windows.Forms.SaveFileDialog();
            this.B_word = new System.Windows.Forms.Button();
            this.B_clear = new System.Windows.Forms.Button();
            this.Pa_mail = new System.Windows.Forms.Panel();
            this.TB_sub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_to = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.B_send = new System.Windows.Forms.Button();
            this.B_cl_mail = new System.Windows.Forms.Button();
            this.Pa_txt = new System.Windows.Forms.Panel();
            this.TC1 = new System.Windows.Forms.RichTextBox();
            this.B_bold = new System.Windows.Forms.Button();
            this.B_reg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_size = new System.Windows.Forms.TextBox();
            this.Pa_mail.SuspendLayout();
            this.Pa_txt.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_mail
            // 
            this.B_mail.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_mail.Location = new System.Drawing.Point(12, 12);
            this.B_mail.Name = "B_mail";
            this.B_mail.Size = new System.Drawing.Size(79, 25);
            this.B_mail.TabIndex = 38;
            this.B_mail.Text = "EMAIL";
            this.B_mail.UseVisualStyleBackColor = true;
            this.B_mail.Click += new System.EventHandler(this.pr_mail);
            // 
            // SFD1
            // 
            this.SFD1.CheckFileExists = true;
            this.SFD1.CreatePrompt = true;
            this.SFD1.Filter = "Word files (*.doc;*.docx)|";
            this.SFD1.SupportMultiDottedExtensions = true;
            this.SFD1.ValidateNames = false;
            this.SFD1.FileOk += new System.ComponentModel.CancelEventHandler(this.pr_save2);
            // 
            // B_word
            // 
            this.B_word.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_word.Location = new System.Drawing.Point(112, 12);
            this.B_word.Name = "B_word";
            this.B_word.Size = new System.Drawing.Size(79, 25);
            this.B_word.TabIndex = 39;
            this.B_word.Text = "WORD";
            this.B_word.UseVisualStyleBackColor = true;
            this.B_word.Click += new System.EventHandler(this.pr_save1);
            // 
            // B_clear
            // 
            this.B_clear.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_clear.Location = new System.Drawing.Point(732, 12);
            this.B_clear.Name = "B_clear";
            this.B_clear.Size = new System.Drawing.Size(35, 25);
            this.B_clear.TabIndex = 40;
            this.B_clear.Text = "GO";
            this.B_clear.UseVisualStyleBackColor = true;
            this.B_clear.Click += new System.EventHandler(this.pr_size);
            // 
            // Pa_mail
            // 
            this.Pa_mail.BackColor = System.Drawing.Color.Silver;
            this.Pa_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pa_mail.Controls.Add(this.TB_sub);
            this.Pa_mail.Controls.Add(this.label2);
            this.Pa_mail.Controls.Add(this.TB_from);
            this.Pa_mail.Controls.Add(this.label1);
            this.Pa_mail.Controls.Add(this.TB_to);
            this.Pa_mail.Controls.Add(this.label94);
            this.Pa_mail.Controls.Add(this.B_send);
            this.Pa_mail.Controls.Add(this.B_cl_mail);
            this.Pa_mail.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pa_mail.Location = new System.Drawing.Point(237, 211);
            this.Pa_mail.Name = "Pa_mail";
            this.Pa_mail.Size = new System.Drawing.Size(366, 183);
            this.Pa_mail.TabIndex = 221;
            this.Pa_mail.Visible = false;
            // 
            // TB_sub
            // 
            this.TB_sub.Location = new System.Drawing.Point(50, 105);
            this.TB_sub.Name = "TB_sub";
            this.TB_sub.Size = new System.Drawing.Size(299, 23);
            this.TB_sub.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Subject";
            // 
            // TB_from
            // 
            this.TB_from.Location = new System.Drawing.Point(38, 59);
            this.TB_from.Name = "TB_from";
            this.TB_from.Size = new System.Drawing.Size(299, 23);
            this.TB_from.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "From";
            // 
            // TB_to
            // 
            this.TB_to.Location = new System.Drawing.Point(38, 10);
            this.TB_to.Name = "TB_to";
            this.TB_to.Size = new System.Drawing.Size(299, 23);
            this.TB_to.TabIndex = 48;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.BackColor = System.Drawing.Color.Gainsboro;
            this.label94.Location = new System.Drawing.Point(12, 18);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(23, 16);
            this.label94.TabIndex = 38;
            this.label94.Text = "To";
            // 
            // B_send
            // 
            this.B_send.Location = new System.Drawing.Point(141, 142);
            this.B_send.Name = "B_send";
            this.B_send.Size = new System.Drawing.Size(79, 25);
            this.B_send.TabIndex = 37;
            this.B_send.Text = "SEND";
            this.B_send.UseVisualStyleBackColor = true;
            this.B_send.Click += new System.EventHandler(this.pr_send);
            // 
            // B_cl_mail
            // 
            this.B_cl_mail.BackColor = System.Drawing.Color.White;
            this.B_cl_mail.Image = ((System.Drawing.Image)(resources.GetObject("B_cl_mail.Image")));
            this.B_cl_mail.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.B_cl_mail.Location = new System.Drawing.Point(343, -1);
            this.B_cl_mail.Name = "B_cl_mail";
            this.B_cl_mail.Size = new System.Drawing.Size(22, 24);
            this.B_cl_mail.TabIndex = 7;
            this.B_cl_mail.UseVisualStyleBackColor = false;
            this.B_cl_mail.Click += new System.EventHandler(this.pr_cl_mail);
            // 
            // Pa_txt
            // 
            this.Pa_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Pa_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pa_txt.Controls.Add(this.Pa_mail);
            this.Pa_txt.Controls.Add(this.TC1);
            this.Pa_txt.Location = new System.Drawing.Point(37, 53);
            this.Pa_txt.Name = "Pa_txt";
            this.Pa_txt.Size = new System.Drawing.Size(834, 508);
            this.Pa_txt.TabIndex = 223;
            // 
            // TC1
            // 
            this.TC1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TC1.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC1.Location = new System.Drawing.Point(42, 8);
            this.TC1.Name = "TC1";
            this.TC1.Size = new System.Drawing.Size(791, 500);
            this.TC1.TabIndex = 223;
            this.TC1.Text = "";
            this.TC1.SelectionChanged += new System.EventHandler(this.pr_selc);
            // 
            // B_bold
            // 
            this.B_bold.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_bold.Location = new System.Drawing.Point(479, 12);
            this.B_bold.Name = "B_bold";
            this.B_bold.Size = new System.Drawing.Size(79, 25);
            this.B_bold.TabIndex = 224;
            this.B_bold.Text = "Font bold";
            this.B_bold.UseVisualStyleBackColor = true;
            this.B_bold.Click += new System.EventHandler(this.pr_bold);
            // 
            // B_reg
            // 
            this.B_reg.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_reg.Location = new System.Drawing.Point(558, 12);
            this.B_reg.Name = "B_reg";
            this.B_reg.Size = new System.Drawing.Size(91, 25);
            this.B_reg.TabIndex = 225;
            this.B_reg.Text = "Font regular";
            this.B_reg.UseVisualStyleBackColor = true;
            this.B_reg.Click += new System.EventHandler(this.pr_reg);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 226;
            this.label3.Text = "SIZE";
            // 
            // TB_size
            // 
            this.TB_size.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_size.Location = new System.Drawing.Point(690, 12);
            this.TB_size.Name = "TB_size";
            this.TB_size.Size = new System.Drawing.Size(40, 23);
            this.TB_size.TabIndex = 227;
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(909, 573);
            this.Controls.Add(this.TB_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_reg);
            this.Controls.Add(this.B_bold);
            this.Controls.Add(this.B_clear);
            this.Controls.Add(this.B_word);
            this.Controls.Add(this.B_mail);
            this.Controls.Add(this.Pa_txt);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 10);
            this.Name = "Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Forms";
            this.Load += new System.EventHandler(this.pr_loadform);
            this.Pa_mail.ResumeLayout(false);
            this.Pa_mail.PerformLayout();
            this.Pa_txt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_mail;
        private System.Windows.Forms.SaveFileDialog SFD1;
        private System.Windows.Forms.Button B_word;
        private System.Windows.Forms.Button B_clear;
        private System.Windows.Forms.Panel Pa_mail;
        private System.Windows.Forms.TextBox TB_to;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Button B_send;
        private System.Windows.Forms.Button B_cl_mail;
        private System.Windows.Forms.TextBox TB_sub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pa_txt;
        private System.Windows.Forms.RichTextBox TC1;
        private System.Windows.Forms.Button B_bold;
        private System.Windows.Forms.Button B_reg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_size;

    }
}