namespace TimeClock
{
    partial class ClockForm
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
            label_empTZ = new Label();
            label_tzValue = new Label();
            label_lastEnterDateValue = new Label();
            label_lastEnterDate = new Label();
            label_lastExitDateValue = new Label();
            label_lastExitDate = new Label();
            linkLabel_cancel = new LinkLabel();
            button_enter = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label_empTZ
            // 
            label_empTZ.AutoSize = true;
            label_empTZ.Font = new Font("Segoe UI", 20F);
            label_empTZ.Location = new Point(137, 62);
            label_empTZ.Name = "label_empTZ";
            label_empTZ.Size = new Size(169, 46);
            label_empTZ.TabIndex = 0;
            label_empTZ.Text = "זהות עובד:";
            // 
            // label_tzValue
            // 
            label_tzValue.AutoSize = true;
            label_tzValue.Font = new Font("Segoe UI", 20F);
            label_tzValue.ForeColor = Color.MediumSeaGreen;
            label_tzValue.Location = new Point(315, 62);
            label_tzValue.Name = "label_tzValue";
            label_tzValue.Size = new Size(182, 46);
            label_tzValue.TabIndex = 1;
            // 
            // label_lastEnterDateValue
            // 
            label_lastEnterDateValue.AutoSize = true;
            label_lastEnterDateValue.Font = new Font("Segoe UI", 12F);
            label_lastEnterDateValue.ForeColor = Color.MediumSeaGreen;
            label_lastEnterDateValue.Location = new Point(236, 172);
            label_lastEnterDateValue.Name = "label_lastEnterDateValue";
            label_lastEnterDateValue.Size = new Size(94, 28);
            label_lastEnterDateValue.TabIndex = 3;
            label_lastEnterDateValue.RightToLeft = RightToLeft.No;
            // 
            // label_lastEnterDate
            // 
            label_lastEnterDate.AutoSize = true;
            label_lastEnterDate.Font = new Font("Segoe UI", 12F);
            label_lastEnterDate.Location = new Point(236, 142);
            label_lastEnterDate.Name = "label_lastEnterDate";
            label_lastEnterDate.Size = new Size(176, 28);
            label_lastEnterDate.TabIndex = 2;
            label_lastEnterDate.Text = "תאריך כניסה אחרון";
            // 
            // label_lastExitDateValue
            // 
            label_lastExitDateValue.AutoSize = true;
            label_lastExitDateValue.Font = new Font("Segoe UI", 12F);
            label_lastExitDateValue.ForeColor = Color.Salmon;
            label_lastExitDateValue.Location = new Point(236, 243);
            label_lastExitDateValue.Name = "label_lastExitDateValue";
            label_lastExitDateValue.Size = new Size(94, 28);
            label_lastExitDateValue.TabIndex = 5;
            label_lastExitDateValue.RightToLeft = RightToLeft.No;
            // 
            // label_lastExitDate
            // 
            label_lastExitDate.AutoSize = true;
            label_lastExitDate.Font = new Font("Segoe UI", 12F);
            label_lastExitDate.Location = new Point(236, 213);
            label_lastExitDate.Name = "label_lastExitDate";
            label_lastExitDate.Size = new Size(173, 28);
            label_lastExitDate.TabIndex = 4;
            label_lastExitDate.Text = "תאריך יציאה אחרון";
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Font = new Font("Segoe UI", 12F);
            linkLabel_cancel.Location = new Point(296, 279);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(58, 28);
            linkLabel_cancel.TabIndex = 6;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += LinkLabel_cancel_LinkClicked;
            // 
            // button_enter
            // 
            button_enter.BackColor = Color.LightGreen;
            button_enter.Font = new Font("Segoe UI", 15F);
            button_enter.Location = new Point(156, 329);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(121, 74);
            button_enter.TabIndex = 7;
            button_enter.Text = "כניסה";
            button_enter.UseVisualStyleBackColor = false;
            button_enter.Click += Button_enter_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Salmon;
            button_exit.Font = new Font("Segoe UI", 15F);
            button_exit.Location = new Point(376, 329);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(121, 74);
            button_exit.TabIndex = 8;
            button_exit.Text = "יציאה";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += Button_exit_Click;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(button_exit);
            Controls.Add(button_enter);
            Controls.Add(linkLabel_cancel);
            Controls.Add(label_lastExitDateValue);
            Controls.Add(label_lastExitDate);
            Controls.Add(label_lastEnterDateValue);
            Controls.Add(label_lastEnterDate);
            Controls.Add(label_tzValue);
            Controls.Add(label_empTZ);
            Name = "ClockForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ClockForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_empTZ;
        private Label label_tzValue;
        private Label label_lastEnterDateValue;
        private Label label_lastEnterDate;
        private Label label_lastExitDateValue;
        private Label label_lastExitDate;
        private LinkLabel linkLabel_cancel;
        private Button button_enter;
        private Button button_exit;
    }
}