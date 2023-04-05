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
            addTask_button = new Button();
            deleteTask_button = new Button();
            todolist_dataGridView = new DataGridView();
            filter_dateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)todolist_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // addTask_button
            // 
            addTask_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addTask_button.Location = new Point(621, 12);
            addTask_button.Name = "addTask_button";
            addTask_button.Size = new Size(94, 29);
            addTask_button.TabIndex = 0;
            addTask_button.Text = "Добавить";
            addTask_button.UseVisualStyleBackColor = true;
            addTask_button.Click += addTask_button_Click;
            // 
            // deleteTask_button
            // 
            deleteTask_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteTask_button.Location = new Point(730, 12);
            deleteTask_button.Name = "deleteTask_button";
            deleteTask_button.Size = new Size(94, 29);
            deleteTask_button.TabIndex = 1;
            deleteTask_button.Text = "Очистить";
            deleteTask_button.UseVisualStyleBackColor = true;
            deleteTask_button.Click += deleteTask_button_Click;
            // 
            // todolist_dataGridView
            // 
            todolist_dataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            todolist_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todolist_dataGridView.Location = new Point(12, 47);
            todolist_dataGridView.Name = "todolist_dataGridView";
            todolist_dataGridView.RowHeadersWidth = 51;
            todolist_dataGridView.RowTemplate.Height = 29;
            todolist_dataGridView.Size = new Size(812, 431);
            todolist_dataGridView.TabIndex = 2;
            todolist_dataGridView.CellValueChanged += todolist_dataGridView_CellValueChanged;
            // 
            // filter_dateTimePicker
            // 
            filter_dateTimePicker.Location = new Point(12, 14);
            filter_dateTimePicker.Name = "filter_dateTimePicker";
            filter_dateTimePicker.Size = new Size(216, 27);
            filter_dateTimePicker.TabIndex = 3;
            filter_dateTimePicker.ValueChanged += filter_dateTimePicker_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 490);
            Controls.Add(filter_dateTimePicker);
            Controls.Add(todolist_dataGridView);
            Controls.Add(deleteTask_button);
            Controls.Add(addTask_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)todolist_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addTask_button;
        private Button deleteTask_button;
        private DataGridView todolist_dataGridView;
        private DateTimePicker filter_dateTimePicker;
    }
}