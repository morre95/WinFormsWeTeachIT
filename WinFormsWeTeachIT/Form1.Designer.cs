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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            goButton = new Button();
            addressBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(-1, 28);
            webView21.Name = "webView21";
            webView21.Size = new Size(802, 423);
            webView21.Source = new Uri("https://www.google.com", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // goButton
            // 
            goButton.Location = new Point(726, 4);
            goButton.Name = "goButton";
            goButton.Size = new Size(75, 23);
            goButton.TabIndex = 1;
            goButton.Text = "Go";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // addressBox
            // 
            addressBox.Location = new Point(3, 4);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(724, 23);
            addressBox.TabIndex = 2;
            addressBox.KeyDown += Address_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addressBox);
            Controls.Add(goButton);
            Controls.Add(webView21);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button goButton;
        private TextBox addressBox;
    }
}
