namespace TimeClock
{
    partial class LoginForm
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
            label_tz = new Label();
            textBox_tz = new TextBox();
            textBox_password = new TextBox();
            label_password = new Label();
            button_login = new Button();
            button_changePassword = new Button();
            SuspendLayout();
            // 
            // label_tz
            // 
            label_tz.AutoSize = true;
            label_tz.Font = new Font("Segoe UI", 15F);
            label_tz.Location = new Point(266, 76);
            label_tz.Name = "label_tz";
            label_tz.Size = new Size(141, 35);
            label_tz.TabIndex = 0;
            label_tz.Text = "תעודת זהות";
            // 
            // textBox_tz
            // 
            textBox_tz.Location = new Point(254, 116);
            textBox_tz.Name = "textBox_tz";
            textBox_tz.Size = new Size(170, 27);
            textBox_tz.TabIndex = 1;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(253, 194);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(170, 27);
            textBox_password.TabIndex = 3;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 15F);
            label_password.Location = new Point(287, 154);
            label_password.Name = "label_password";
            label_password.Size = new Size(89, 35);
            label_password.TabIndex = 2;
            label_password.Text = "סיסמא";
            // 
            // button_login
            // 
            button_login.Font = new Font("Segoe UI", 12F);
            button_login.Location = new Point(249, 274);
            button_login.Name = "button_login";
            button_login.Size = new Size(176, 39);
            button_login.TabIndex = 4;
            button_login.Text = "כניסה";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += Button_login_Click;
            // 
            // button_changePassword
            // 
            button_changePassword.Font = new Font("Segoe UI", 12F);
            button_changePassword.Location = new Point(249, 322);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(176, 41);
            button_changePassword.TabIndex = 5;
            button_changePassword.Text = "החלפת סיסמא";
            button_changePassword.UseVisualStyleBackColor = true;
            button_changePassword.Click += Button_changePassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(612, 450);
            Controls.Add(button_changePassword);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(label_password);
            Controls.Add(textBox_tz);
            Controls.Add(label_tz);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_tz;
        private TextBox textBox_tz;
        private TextBox textBox_password;
        private Label label_password;
        private Button button_login;
        private Button button_changePassword;
    }
}