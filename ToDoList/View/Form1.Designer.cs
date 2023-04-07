namespace ToDoList
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
            this.addTask_button = new System.Windows.Forms.Button();
            this.deleteTask_button = new System.Windows.Forms.Button();
            this.todolist_dataGridView = new System.Windows.Forms.DataGridView();
            this.filter_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.todolist_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTask_button
            // 
            this.addTask_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTask_button.Location = new System.Drawing.Point(543, 9);
            this.addTask_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTask_button.Name = "addTask_button";
            this.addTask_button.Size = new System.Drawing.Size(82, 22);
            this.addTask_button.TabIndex = 0;
            this.addTask_button.Text = "Добавить";
            this.addTask_button.UseVisualStyleBackColor = true;
            // 
            // deleteTask_button
            // 
            this.deleteTask_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTask_button.Location = new System.Drawing.Point(639, 9);
            this.deleteTask_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteTask_button.Name = "deleteTask_button";
            this.deleteTask_button.Size = new System.Drawing.Size(82, 22);
            this.deleteTask_button.TabIndex = 1;
            this.deleteTask_button.Text = "Очистить";
            this.deleteTask_button.UseVisualStyleBackColor = true;
            // 
            // todolist_dataGridView
            // 
            this.todolist_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todolist_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todolist_dataGridView.Location = new System.Drawing.Point(10, 35);
            this.todolist_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todolist_dataGridView.Name = "todolist_dataGridView";
            this.todolist_dataGridView.RowHeadersWidth = 51;
            this.todolist_dataGridView.RowTemplate.Height = 29;
            this.todolist_dataGridView.Size = new System.Drawing.Size(710, 323);
            this.todolist_dataGridView.TabIndex = 2;
            // 
            // filter_dateTimePicker
            // 
            this.filter_dateTimePicker.Location = new System.Drawing.Point(10, 10);
            this.filter_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter_dateTimePicker.Name = "filter_dateTimePicker";
            this.filter_dateTimePicker.Size = new System.Drawing.Size(190, 23);
            this.filter_dateTimePicker.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 368);
            this.Controls.Add(this.filter_dateTimePicker);
            this.Controls.Add(this.todolist_dataGridView);
            this.Controls.Add(this.deleteTask_button);
            this.Controls.Add(this.addTask_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.todolist_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button addTask_button;
        private Button deleteTask_button;
        private DataGridView todolist_dataGridView;
        private DateTimePicker filter_dateTimePicker;
    }
}