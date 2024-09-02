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
            textBook = new TextBox();
            buttonNew = new Button();
            debugLabel = new Label();
            checkBoxAvailable = new CheckBox();
            SuspendLayout();
            // 
            // textBook
            // 
            textBook.Location = new Point(13, 56);
            textBook.Name = "textBook";
            textBook.Size = new Size(398, 23);
            textBook.TabIndex = 0;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(13, 27);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 1;
            buttonNew.Text = "Tipsa mig!";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // debugLabel
            // 
            debugLabel.AutoSize = true;
            debugLabel.Cursor = Cursors.No;
            debugLabel.ForeColor = Color.Red;
            debugLabel.Location = new Point(13, 84);
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(0, 15);
            debugLabel.TabIndex = 4;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(417, 60);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(81, 19);
            checkBoxAvailable.TabIndex = 5;
            checkBoxAvailable.Text = "Tillgänglig";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            checkBoxAvailable.CheckedChanged += CheckBoxAvailable_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 102);
            Controls.Add(checkBoxAvailable);
            Controls.Add(debugLabel);
            Controls.Add(buttonNew);
            Controls.Add(textBook);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBook;
        private Button buttonNew;
        private Label debugLabel;
        private CheckBox checkBoxAvailable;
    }
}
