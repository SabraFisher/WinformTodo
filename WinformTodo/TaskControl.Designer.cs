namespace WinformTodo
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComplete = new Button();
            label1 = new Label();
            label2 = new Label();
            lblDueDate = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnComplete
            // 
            btnComplete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComplete.AutoSize = true;
            btnComplete.Location = new Point(199, 125);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(101, 25);
            btnComplete.TabIndex = 0;
            btnComplete.Text = "Mark Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1;
            label1.Text = "Due Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 21);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDueDate.Location = new Point(106, 3);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(78, 17);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = " 2025-01-01";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(3, 42);
            lblDescription.MaximumSize = new Size(290, 60);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(131, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description of Task";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(lblDescription);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComplete);
            Name = "TaskControl";
            Size = new Size(300, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComplete;
        private Label label1;
        private Label label2;
        private Label lblDueDate;
        private Label lblDescription;
    }
}
