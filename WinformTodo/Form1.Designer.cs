namespace WinformTodo
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            txtDueDate = new TextBox();
            lblDueDate = new Label();
            lblTaskBoxLabel = new Label();
            txtTaskDescription = new TextBox();
            gbTaskList = new GroupBox();
            fpTasks = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(lblDueDate);
            groupBox1.Controls.Add(lblTaskBoxLabel);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Entry Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(172, 79);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(253, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Task ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += submitForm;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(76, 50);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "2025-01-20";
            txtDueDate.Size = new Size(252, 25);
            txtDueDate.TabIndex = 3;
            txtDueDate.KeyPress += Form1_KeyPress;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(6, 53);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(67, 19);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "Due Date";
            // 
            // lblTaskBoxLabel
            // 
            lblTaskBoxLabel.AutoSize = true;
            lblTaskBoxLabel.Location = new Point(32, 27);
            lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            lblTaskBoxLabel.Size = new Size(34, 19);
            lblTaskBoxLabel.TabIndex = 1;
            lblTaskBoxLabel.Text = "Task";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(76, 19);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(252, 25);
            txtTaskDescription.TabIndex = 0;
            txtTaskDescription.KeyPress += Form1_KeyPress;
            // 
            // gbTaskList
            // 
            gbTaskList.Font = new Font("Segoe UI", 12F);
            gbTaskList.Location = new Point(12, 128);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(374, 489);
            gbTaskList.TabIndex = 2;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // fpTasks
            // 
            fpTasks.AutoScroll = true;
            fpTasks.Location = new Point(12, 156);
            fpTasks.Name = "fpTasks";
            fpTasks.Size = new Size(368, 455);
            fpTasks.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 629);
            Controls.Add(fpTasks);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Sabra's To-Do App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTaskDescription;
        private TextBox txtDueDate;
        private Label lblDueDate;
        private Label lblTaskBoxLabel;
        private Button btnAdd;
        private Button btnClear;
        private GroupBox gbTaskList;
        private FlowLayoutPanel fpTasks;
    }
}
