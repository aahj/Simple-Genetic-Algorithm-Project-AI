namespace GA__windowsForm_project
{
    partial class Form2
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
            this.Login = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.email_inp = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.pass_inp = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.sign_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Cursor = System.Windows.Forms.Cursors.No;
            this.Login.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.DarkRed;
            this.Login.Location = new System.Drawing.Point(299, 34);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(5);
            this.Login.Size = new System.Drawing.Size(133, 54);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Cursor = System.Windows.Forms.Cursors.No;
            this.email.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Maroon;
            this.email.Location = new System.Drawing.Point(208, 147);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(5);
            this.email.Size = new System.Drawing.Size(76, 38);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // email_inp
            // 
            this.email_inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_inp.Location = new System.Drawing.Point(414, 146);
            this.email_inp.Name = "email_inp";
            this.email_inp.Size = new System.Drawing.Size(189, 26);
            this.email_inp.TabIndex = 2;
            this.email_inp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Cursor = System.Windows.Forms.Cursors.No;
            this.pass.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Maroon;
            this.pass.Location = new System.Drawing.Point(208, 241);
            this.pass.Name = "pass";
            this.pass.Padding = new System.Windows.Forms.Padding(5);
            this.pass.Size = new System.Drawing.Size(119, 38);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password";
            // 
            // pass_inp
            // 
            this.pass_inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_inp.Location = new System.Drawing.Point(414, 241);
            this.pass_inp.Name = "pass_inp";
            this.pass_inp.PasswordChar = '*';
            this.pass_inp.Size = new System.Drawing.Size(189, 26);
            this.pass_inp.TabIndex = 4;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Beige;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.login_btn.Location = new System.Drawing.Point(330, 320);
            this.login_btn.Name = "login_btn";
            this.login_btn.Padding = new System.Windows.Forms.Padding(4);
            this.login_btn.Size = new System.Drawing.Size(142, 35);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // sign_up
            // 
            this.sign_up.BackColor = System.Drawing.Color.Aqua;
            this.sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up.ForeColor = System.Drawing.Color.DarkRed;
            this.sign_up.Location = new System.Drawing.Point(276, 378);
            this.sign_up.Name = "sign_up";
            this.sign_up.Padding = new System.Windows.Forms.Padding(4);
            this.sign_up.Size = new System.Drawing.Size(242, 39);
            this.sign_up.TabIndex = 6;
            this.sign_up.Text = "Sign Up";
            this.sign_up.UseVisualStyleBackColor = false;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GA__windowsForm_project.Properties.Resources.study;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pass_inp);
            this.Controls.Add(this.email_inp);
            this.Controls.Add(this.Login);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox email_inp;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox pass_inp;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button sign_up;
    }
}