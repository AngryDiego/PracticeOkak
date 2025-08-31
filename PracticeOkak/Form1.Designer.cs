namespace PracticeOkak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelEnter = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelERRLogin = new System.Windows.Forms.Label();
            this.labelERRPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelToReg = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(55)))), ((int)(((byte)(144)))));
            this.buttonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(36)))), ((int)(((byte)(134)))));
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.buttonEnter.Location = new System.Drawing.Point(175, 240);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(114, 73);
            this.buttonEnter.TabIndex = 0;
            this.buttonEnter.Text = "enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            this.buttonEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonEnter_KeyPress);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.labelEnter.Location = new System.Drawing.Point(170, 55);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(134, 29);
            this.labelEnter.TabIndex = 1;
            this.labelEnter.Text = "Enter login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(76)))), ((int)(((byte)(154)))));
            this.textBoxLogin.Location = new System.Drawing.Point(120, 109);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(221, 35);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(76)))), ((int)(((byte)(154)))));
            this.textBoxPassword.Location = new System.Drawing.Point(120, 166);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(221, 35);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelERRLogin
            // 
            this.labelERRLogin.AutoSize = true;
            this.labelERRLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.labelERRLogin.Location = new System.Drawing.Point(375, 112);
            this.labelERRLogin.Name = "labelERRLogin";
            this.labelERRLogin.Size = new System.Drawing.Size(44, 16);
            this.labelERRLogin.TabIndex = 4;
            this.labelERRLogin.Text = "label1";
            this.labelERRLogin.Visible = false;
            // 
            // labelERRPassword
            // 
            this.labelERRPassword.AutoSize = true;
            this.labelERRPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.labelERRPassword.Location = new System.Drawing.Point(375, 169);
            this.labelERRPassword.Name = "labelERRPassword";
            this.labelERRPassword.Size = new System.Drawing.Size(44, 16);
            this.labelERRPassword.TabIndex = 5;
            this.labelERRPassword.Text = "label2";
            this.labelERRPassword.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(5)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.linkLabelToReg);
            this.panel1.Controls.Add(this.labelERRLogin);
            this.panel1.Controls.Add(this.labelERRPassword);
            this.panel1.Controls.Add(this.labelEnter);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Location = new System.Drawing.Point(141, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 411);
            this.panel1.TabIndex = 21;
            // 
            // linkLabelToReg
            // 
            this.linkLabelToReg.AutoSize = true;
            this.linkLabelToReg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(117)))));
            this.linkLabelToReg.Location = new System.Drawing.Point(108, 332);
            this.linkLabelToReg.Name = "linkLabelToReg";
            this.linkLabelToReg.Size = new System.Drawing.Size(253, 16);
            this.linkLabelToReg.TabIndex = 6;
            this.linkLabelToReg.TabStop = true;
            this.linkLabelToReg.Text = "Don\'t have account yet? Make a new one!";
            this.linkLabelToReg.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(117)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 475);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelERRLogin;
        private System.Windows.Forms.Label labelERRPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelToReg;
    }
}

