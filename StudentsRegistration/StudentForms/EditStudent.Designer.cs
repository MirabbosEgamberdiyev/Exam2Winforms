namespace StudentsRegistration.StudentForms
{
    partial class EditStudent
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
            label1 = new Label();
            fullname_textbox = new TextBox();
            age_textbox = new TextBox();
            label2 = new Label();
            phoneNumber_textbox = new TextBox();
            label3 = new Label();
            address_textbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cancel_btn = new Button();
            save_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // fullname_textbox
            // 
            fullname_textbox.Anchor = AnchorStyles.None;
            fullname_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            fullname_textbox.Location = new Point(12, 94);
            fullname_textbox.Name = "fullname_textbox";
            fullname_textbox.Size = new Size(286, 33);
            fullname_textbox.TabIndex = 1;
            // 
            // age_textbox
            // 
            age_textbox.Anchor = AnchorStyles.None;
            age_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            age_textbox.Location = new Point(360, 94);
            age_textbox.Name = "age_textbox";
            age_textbox.Size = new Size(286, 33);
            age_textbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 66);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 2;
            label2.Text = "Age";
            // 
            // phoneNumber_textbox
            // 
            phoneNumber_textbox.Anchor = AnchorStyles.None;
            phoneNumber_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumber_textbox.Location = new Point(12, 176);
            phoneNumber_textbox.Name = "phoneNumber_textbox";
            phoneNumber_textbox.Size = new Size(286, 33);
            phoneNumber_textbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 4;
            label3.Text = "Phone Number";
            // 
            // address_textbox
            // 
            address_textbox.Anchor = AnchorStyles.None;
            address_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            address_textbox.Location = new Point(356, 176);
            address_textbox.Name = "address_textbox";
            address_textbox.Size = new Size(286, 33);
            address_textbox.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(356, 148);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(224, 18);
            label5.Name = "label5";
            label5.Size = new Size(211, 30);
            label5.TabIndex = 8;
            label5.Text = "Edit exciting Student";
            // 
            // cancel_btn
            // 
            cancel_btn.Anchor = AnchorStyles.None;
            cancel_btn.BackColor = SystemColors.ActiveBorder;
            cancel_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.ForeColor = Color.White;
            cancel_btn.Location = new Point(96, 256);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(202, 50);
            cancel_btn.TabIndex = 9;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Anchor = AnchorStyles.None;
            save_btn.BackColor = Color.FromArgb(0, 192, 0);
            save_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.ForeColor = Color.White;
            save_btn.Location = new Point(356, 256);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(202, 50);
            save_btn.TabIndex = 10;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 346);
            Controls.Add(save_btn);
            Controls.Add(cancel_btn);
            Controls.Add(label5);
            Controls.Add(address_textbox);
            Controls.Add(label4);
            Controls.Add(phoneNumber_textbox);
            Controls.Add(label3);
            Controls.Add(age_textbox);
            Controls.Add(label2);
            Controls.Add(fullname_textbox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Student";
            Load += EditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fullname_textbox;
        private TextBox age_textbox;
        private Label label2;
        private TextBox phoneNumber_textbox;
        private Label label3;
        private TextBox address_textbox;
        private Label label4;
        private Label label5;
        private Button cancel_btn;
        private Button save_btn;
    }
}