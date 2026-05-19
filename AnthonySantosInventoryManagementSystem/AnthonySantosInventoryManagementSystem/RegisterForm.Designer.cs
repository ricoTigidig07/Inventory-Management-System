namespace AnthonySantosInventoryManagementSystem
{
    partial class RegisterForm
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
            this.LabelConfirmPassword = new System.Windows.Forms.Label();
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // LabelTitle
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.Navy;
            this.LabelTitle.Location = new System.Drawing.Point(80, 20);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(240, 32);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Create New Account";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // LabelUsername
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelUsername.Location = new System.Drawing.Point(50, 80);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(84, 21);
            this.LabelUsername.TabIndex = 1;
            this.LabelUsername.Text = "Username:";

            // TextBoxUsername
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxUsername.Location = new System.Drawing.Point(160, 77);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(200, 29);
            this.TextBoxUsername.TabIndex = 2;

            // LabelEmail
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelEmail.Location = new System.Drawing.Point(50, 120);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(51, 21);
            this.LabelEmail.TabIndex = 3;
            this.LabelEmail.Text = "Email:";

            // TextBoxEmail
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxEmail.Location = new System.Drawing.Point(160, 117);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(200, 29);
            this.TextBoxEmail.TabIndex = 4;

            // LabelPassword
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelPassword.Location = new System.Drawing.Point(50, 160);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(80, 21);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Password:";

            // TextBoxPassword
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxPassword.Location = new System.Drawing.Point(160, 157);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(200, 29);
            this.TextBoxPassword.TabIndex = 6;
            this.TextBoxPassword.UseSystemPasswordChar = true;

            // LabelConfirmPassword
            this.LabelConfirmPassword.AutoSize = true;
            this.LabelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelConfirmPassword.Location = new System.Drawing.Point(20, 200);
            this.LabelConfirmPassword.Name = "LabelConfirmPassword";
            this.LabelConfirmPassword.Size = new System.Drawing.Size(134, 21);
            this.LabelConfirmPassword.TabIndex = 7;
            this.LabelConfirmPassword.Text = "Confirm Password:";

            // TextBoxConfirmPassword
            this.TextBoxConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(160, 197);
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(200, 29);
            this.TextBoxConfirmPassword.TabIndex = 8;
            this.TextBoxConfirmPassword.UseSystemPasswordChar = true;

            // ButtonCreate
            this.ButtonCreate.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonCreate.Location = new System.Drawing.Point(80, 260);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(120, 40);
            this.ButtonCreate.TabIndex = 9;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);

            // ButtonCancel
            this.ButtonCancel.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonCancel.Location = new System.Drawing.Point(220, 260);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(120, 40);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);

            // LabelError
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(80, 320);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(0, 19);
            this.LabelError.TabIndex = 11;

            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 380);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.TextBoxConfirmPassword);
            this.Controls.Add(this.LabelConfirmPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelTitle);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register - Inventory System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelConfirmPassword;
        private System.Windows.Forms.TextBox TextBoxConfirmPassword;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox TextBoxEmail;
    }
}