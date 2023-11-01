namespace StudentsRegistration
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            delete_btn = new Button();
            edit_btn = new Button();
            add_btn = new Button();
            refresh_btn = new Button();
            panel2 = new Panel();
            search_textbox = new TextBox();
            label1 = new Label();
            studentsTable = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(delete_btn);
            panel1.Controls.Add(edit_btn);
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(refresh_btn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 412);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 75);
            panel1.TabIndex = 0;
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.None;
            delete_btn.BackColor = Color.FromArgb(192, 0, 0);
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(602, 17);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(132, 46);
            delete_btn.TabIndex = 2;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Anchor = AnchorStyles.None;
            edit_btn.BackColor = Color.SkyBlue;
            edit_btn.FlatAppearance.BorderSize = 0;
            edit_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            edit_btn.ForeColor = Color.White;
            edit_btn.Location = new Point(416, 17);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(132, 46);
            edit_btn.TabIndex = 2;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Anchor = AnchorStyles.None;
            add_btn.BackColor = Color.FromArgb(0, 192, 0);
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(230, 17);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(132, 46);
            add_btn.TabIndex = 1;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // refresh_btn
            // 
            refresh_btn.Anchor = AnchorStyles.None;
            refresh_btn.BackColor = Color.SkyBlue;
            refresh_btn.FlatAppearance.BorderSize = 0;
            refresh_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_btn.ForeColor = Color.White;
            refresh_btn.Location = new Point(44, 17);
            refresh_btn.Name = "refresh_btn";
            refresh_btn.Size = new Size(132, 46);
            refresh_btn.TabIndex = 0;
            refresh_btn.Text = "Refresh";
            refresh_btn.UseVisualStyleBackColor = false;
            refresh_btn.Click += refresh_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(search_textbox);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 69);
            panel2.TabIndex = 1;
            // 
            // search_textbox
            // 
            search_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_textbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            search_textbox.Location = new Point(472, 18);
            search_textbox.Name = "search_textbox";
            search_textbox.PlaceholderText = "Search by fullname";
            search_textbox.Size = new Size(280, 33);
            search_textbox.TabIndex = 1;
            search_textbox.TextChanged += search_textbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 0;
            label1.Text = "Students table";
            // 
            // studentsTable
            // 
            studentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsTable.Dock = DockStyle.Fill;
            studentsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            studentsTable.Location = new Point(0, 69);
            studentsTable.Name = "studentsTable";
            studentsTable.RowTemplate.Height = 25;
            studentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsTable.Size = new Size(775, 343);
            studentsTable.TabIndex = 0;
            studentsTable.CellClick += studentsTable_CellClick;
            studentsTable.CellContentClick += studentsTable_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 487);
            Controls.Add(studentsTable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView studentsTable;
        private Button delete_btn;
        private Button edit_btn;
        private Button add_btn;
        private Button refresh_btn;
        private TextBox search_textbox;
    }
}