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
            pictureBox1 = new PictureBox();
            radioImage1 = new RadioButton();
            radioImage2 = new RadioButton();
            radioImage3 = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 210);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // radioImage1
            // 
            radioImage1.AutoSize = true;
            radioImage1.Location = new Point(253, 225);
            radioImage1.Name = "radioImage1";
            radioImage1.Size = new Size(67, 19);
            radioImage1.TabIndex = 4;
            radioImage1.TabStop = true;
            radioImage1.Text = "Image 1";
            radioImage1.UseVisualStyleBackColor = true;
            radioImage1.Click += RadioBtn_Clicked;
            // 
            // radioImage2
            // 
            radioImage2.AutoSize = true;
            radioImage2.Location = new Point(252, 252);
            radioImage2.Name = "radioImage2";
            radioImage2.Size = new Size(67, 19);
            radioImage2.TabIndex = 5;
            radioImage2.TabStop = true;
            radioImage2.Text = "Image 2";
            radioImage2.UseVisualStyleBackColor = true;
            radioImage2.Click += RadioBtn_Clicked;
            // 
            // radioImage3
            // 
            radioImage3.AutoSize = true;
            radioImage3.Location = new Point(250, 279);
            radioImage3.Name = "radioImage3";
            radioImage3.Size = new Size(67, 19);
            radioImage3.TabIndex = 6;
            radioImage3.TabStop = true;
            radioImage3.Text = "Image 3";
            radioImage3.UseVisualStyleBackColor = true;
            radioImage3.Click += RadioBtn_Clicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioImage3);
            Controls.Add(radioImage2);
            Controls.Add(radioImage1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Panel panel1;
        private Button Insert;
        private Button Delete;
        private Button Add;
        private TextBox textBox;
        private PictureBox pictureBox1;
        private RadioButton radioImage1;
        private RadioButton radioImage2;
        private RadioButton radioImage3;
    }
}
