namespace PracticeOkak
{
    partial class RegistrationForm
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
            this.labelERRPassword = new System.Windows.Forms.Label();
            this.labelERRLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelERRPassword
            // 
            this.labelERRPassword.AutoSize = true;
            this.labelERRPassword.ForeColor = System.Drawing.Color.Red;
            this.labelERRPassword.Location = new System.Drawing.Point(520, 217);
            this.labelERRPassword.Name = "labelERRPassword";
            this.labelERRPassword.Size = new System.Drawing.Size(44, 16);
            this.labelERRPassword.TabIndex = 11;
            this.labelERRPassword.Text = "label2";
            this.labelERRPassword.Visible = false;
            // 
            // labelERRLogin
            // 
            this.labelERRLogin.AutoSize = true;
            this.labelERRLogin.ForeColor = System.Drawing.Color.Red;
            this.labelERRLogin.Location = new System.Drawing.Point(517, 160);
            this.labelERRLogin.Name = "labelERRLogin";
            this.labelERRLogin.Size = new System.Drawing.Size(44, 16);
            this.labelERRLogin.TabIndex = 10;
            this.labelERRLogin.Text = "label1";
            this.labelERRLogin.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(271, 217);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(221, 35);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(271, 160);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(221, 35);
            this.textBoxLogin.TabIndex = 8;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.Location = new System.Drawing.Point(312, 108);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(148, 29);
            this.labelReg.TabIndex = 7;
            this.labelReg.Text = "Registration";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(317, 283);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(114, 73);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelERRPassword);
            this.Controls.Add(this.labelERRLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.buttonEnter);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelERRPassword;
        private System.Windows.Forms.Label labelERRLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Button buttonEnter;
    }
}