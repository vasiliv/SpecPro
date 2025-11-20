namespace SpecPro
{
    partial class Form_Dial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dial));
            this.B_ses = new System.Windows.Forms.Button();
            this.TB_psw = new System.Windows.Forms.TextBox();
            this.TB_mom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_ses
            // 
            this.B_ses.Location = new System.Drawing.Point(118, 114);
            this.B_ses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B_ses.Name = "B_ses";
            this.B_ses.Size = new System.Drawing.Size(75, 24);
            this.B_ses.TabIndex = 32;
            this.B_ses.Text = "შესვლა";
            this.B_ses.UseVisualStyleBackColor = true;
            this.B_ses.Click += new System.EventHandler(this.pr_go);
            // 
            // TB_psw
            // 
            this.TB_psw.Location = new System.Drawing.Point(118, 70);
            this.TB_psw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_psw.Name = "TB_psw";
            this.TB_psw.PasswordChar = '*';
            this.TB_psw.Size = new System.Drawing.Size(160, 22);
            this.TB_psw.TabIndex = 31;
            this.TB_psw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pr_ent);
            // 
            // TB_mom
            // 
            this.TB_mom.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_mom.Location = new System.Drawing.Point(118, 29);
            this.TB_mom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_mom.Name = "TB_mom";
            this.TB_mom.Size = new System.Drawing.Size(186, 27);
            this.TB_mom.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "პაროლი - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "მომხმარებელი - ";
            // 
            // Form_Dial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 167);
            this.Controls.Add(this.B_ses);
            this.Controls.Add(this.TB_psw);
            this.Controls.Add(this.TB_mom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "სახელი და პაროლი";
            this.Load += new System.EventHandler(this.pr_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_ses;
        private System.Windows.Forms.TextBox TB_psw;
        private System.Windows.Forms.TextBox TB_mom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}