namespace AnthonySantosInventoryManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // LabelTitle
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.Navy;
            this.LabelTitle.Location = new System.Drawing.Point(100, 30);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(200, 32);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Inventory System";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // LabelUsername
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelUsername.Location = new System.Drawing.Point(50, 100);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(84, 21);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "Username:";

            // TextBoxUsername
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxUsername.Location = new System.Drawing.Point(160, 97);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(200, 29);
            this.TextBoxUsername.TabIndex = 2;

            // LabelPassword
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelPassword.Location = new System.Drawing.Point(50, 150);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(80, 21);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Password:";

            // TextBoxPassword
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPassword.Location = new System.Drawing.Point(160, 147);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(200, 29);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.UseSystemPasswordChar = true;

            // ButtonLogin
            this.ButtonLogin.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonLogin.Location = new System.Drawing.Point(100, 210);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(100, 40);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);

            // ButtonRegister
            this.ButtonRegister.BackColor = System.Drawing.Color.LightBlue;
            this.ButtonRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonRegister.Location = new System.Drawing.Point(220, 210);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(100, 40);
            this.ButtonRegister.TabIndex = 6;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);

            // LabelError
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(100, 270);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 19);
            this.LabelError.TabIndex = 7;

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelTitle);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Inventory System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Label LabelError;
    }
}