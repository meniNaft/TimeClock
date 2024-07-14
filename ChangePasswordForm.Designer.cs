namespace TimeClock
{
    partial class ChangePasswordForm
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
            textBox_newPassword = new TextBox();
            label_newPassword = new Label();
            textBox_confirmNewPassowrd = new TextBox();
            label_confirmNewPassword = new Label();
            textBox_oldPassword = new TextBox();
            label_oldPassword = new Label();
            button_changePassword = new Button();
            linkLabel_cancel = new LinkLabel();
            SuspendLayout();
            // 
            // label_tz
            // 
            label_tz.AutoSize = true;
            label_tz.Font = new Font("Segoe UI", 13F);
            label_tz.Location = new Point(208, 70);
            label_tz.Name = "label_tz";
            label_tz.Size = new Size(124, 30);
            label_tz.TabIndex = 0;
            label_tz.Text = "תעודת זהות";
            // 
            // textBox_tz
            // 
            textBox_tz.Font = new Font("Segoe UI", 12F);
            textBox_tz.Location = new Point(436, 70);
            textBox_tz.Name = "textBox_tz";
            textBox_tz.Size = new Size(199, 34);
            textBox_tz.TabIndex = 1;
            // 
            // textBox_newPassword
            // 
            textBox_newPassword.BackColor = Color.LightGoldenrodYellow;
            textBox_newPassword.Font = new Font("Segoe UI", 12F);
            textBox_newPassword.Location = new Point(436, 171);
            textBox_newPassword.Name = "textBox_newPassword";
            textBox_newPassword.Size = new Size(199, 34);
            textBox_newPassword.TabIndex = 3;
            // 
            // label_newPassword
            // 
            label_newPassword.AutoSize = true;
            label_newPassword.Font = new Font("Segoe UI", 13F);
            label_newPassword.Location = new Point(208, 171);
            label_newPassword.Name = "label_newPassword";
            label_newPassword.Size = new Size(142, 30);
            label_newPassword.TabIndex = 2;
            label_newPassword.Text = "סיסמא חדשה";
            // 
            // textBox_confirmNewPassowrd
            // 
            textBox_confirmNewPassowrd.BackColor = Color.LightGoldenrodYellow;
            textBox_confirmNewPassowrd.Font = new Font("Segoe UI", 12F);
            textBox_confirmNewPassowrd.Location = new Point(436, 224);
            textBox_confirmNewPassowrd.Name = "textBox_confirmNewPassowrd";
            textBox_confirmNewPassowrd.Size = new Size(199, 34);
            textBox_confirmNewPassowrd.TabIndex = 5;
            // 
            // label_confirmNewPassword
            // 
            label_confirmNewPassword.AutoSize = true;
            label_confirmNewPassword.Font = new Font("Segoe UI", 13F);
            label_confirmNewPassword.Location = new Point(208, 224);
            label_confirmNewPassword.Name = "label_confirmNewPassword";
            label_confirmNewPassword.Size = new Size(203, 30);
            label_confirmNewPassword.TabIndex = 4;
            label_confirmNewPassword.Text = "אישור סיסמא חדשה";
            // 
            // textBox_oldPassword
            // 
            textBox_oldPassword.Font = new Font("Segoe UI", 12F);
            textBox_oldPassword.Location = new Point(436, 120);
            textBox_oldPassword.Name = "textBox_oldPassword";
            textBox_oldPassword.Size = new Size(199, 34);
            textBox_oldPassword.TabIndex = 7;
            // 
            // label_oldPassword
            // 
            label_oldPassword.AutoSize = true;
            label_oldPassword.Font = new Font("Segoe UI", 13F);
            label_oldPassword.Location = new Point(208, 120);
            label_oldPassword.Name = "label_oldPassword";
            label_oldPassword.Size = new Size(131, 30);
            label_oldPassword.TabIndex = 6;
            label_oldPassword.Text = "סיסמא ישנה";
            // 
            // button_changePassword
            // 
            button_changePassword.BackColor = Color.LightGoldenrodYellow;
            button_changePassword.Font = new Font("Segoe UI", 11F);
            button_changePassword.Location = new Point(436, 293);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(199, 41);
            button_changePassword.TabIndex = 8;
            button_changePassword.Text = "ביצוע החלפת סיסמא";
            button_changePassword.UseVisualStyleBackColor = false;
            button_changePassword.Click += button_changePassword_Click;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Font = new Font("Segoe UI", 12F);
            linkLabel_cancel.Location = new Point(251, 306);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(58, 28);
            linkLabel_cancel.TabIndex = 9;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel_cancel);
            Controls.Add(button_changePassword);
            Controls.Add(textBox_oldPassword);
            Controls.Add(label_oldPassword);
            Controls.Add(textBox_confirmNewPassowrd);
            Controls.Add(label_confirmNewPassword);
            Controls.Add(textBox_newPassword);
            Controls.Add(label_newPassword);
            Controls.Add(textBox_tz);
            Controls.Add(label_tz);
            Name = "ChangePasswordForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_tz;
        private TextBox textBox_tz;
        private TextBox textBox_newPassword;
        private Label label_newPassword;
        private TextBox textBox_confirmNewPassowrd;
        private Label label_confirmNewPassword;
        private TextBox textBox_oldPassword;
        private Label label_oldPassword;
        private Button button_changePassword;
        private LinkLabel linkLabel_cancel;
    }
}