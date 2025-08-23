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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelEnter = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelERRLogin = new System.Windows.Forms.Label();
            this.labelERRPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(320, 247);
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
            this.labelEnter.Location = new System.Drawing.Point(315, 72);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(134, 29);
            this.labelEnter.TabIndex = 1;
            this.labelEnter.Text = "Enter login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(274, 124);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(221, 35);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(274, 181);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(221, 35);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelERRLogin
            // 
            this.labelERRLogin.AutoSize = true;
            this.labelERRLogin.ForeColor = System.Drawing.Color.Red;
            this.labelERRLogin.Location = new System.Drawing.Point(520, 124);
            this.labelERRLogin.Name = "labelERRLogin";
            this.labelERRLogin.Size = new System.Drawing.Size(44, 16);
            this.labelERRLogin.TabIndex = 4;
            this.labelERRLogin.Text = "label1";
            this.labelERRLogin.Visible = false;
            // 
            // labelERRPassword
            // 
            this.labelERRPassword.AutoSize = true;
            this.labelERRPassword.ForeColor = System.Drawing.Color.Red;
            this.labelERRPassword.Location = new System.Drawing.Point(523, 181);
            this.labelERRPassword.Name = "labelERRPassword";
            this.labelERRPassword.Size = new System.Drawing.Size(44, 16);
            this.labelERRPassword.TabIndex = 5;
            this.labelERRPassword.Text = "label2";
            this.labelERRPassword.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 475);
            this.Controls.Add(this.labelERRPassword);
            this.Controls.Add(this.labelERRLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.buttonEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelERRLogin;
        private System.Windows.Forms.Label labelERRPassword;
    }
}

