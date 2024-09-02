namespace WinFormsWeTeachIT
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
            listBox = new ListBox();
            panel1 = new Panel();
            textBox = new TextBox();
            Add = new Button();
            Insert = new Button();
            Delete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(20, 20);
            listBox.Name = "listBox";
            listBox.Size = new Size(211, 169);
            listBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(Insert);
            panel1.Controls.Add(Delete);
            panel1.Location = new Point(237, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 153);
            panel1.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.Location = new Point(8, 17);
            textBox.Name = "textBox";
            textBox.Size = new Size(256, 23);
            textBox.TabIndex = 3;
            // 
            // Add
            // 
            Add.Location = new Point(12, 58);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Insert
            // 
            Insert.Location = new Point(12, 116);
            Insert.Name = "Insert";
            Insert.Size = new Size(75, 23);
            Insert.TabIndex = 1;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(12, 87);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 0;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox;
        private Panel panel1;
        private Button Insert;
        private Button Delete;
        private Button Add;
        private TextBox textBox;
    }
}
