namespace WinFormsApp1
{
    partial class frmWelcome
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
            btnsubscribe = new Button();
            label1 = new Label();
            btnaddbook = new Button();
            SuspendLayout();
            // 
            // btnsubscribe
            // 
            btnsubscribe.Location = new Point(220, 75);
            btnsubscribe.Name = "btnsubscribe";
            btnsubscribe.Size = new Size(132, 56);
            btnsubscribe.TabIndex = 1;
            btnsubscribe.Text = "Subscribe";
            btnsubscribe.UseVisualStyleBackColor = true;
            btnsubscribe.Click += btnsubscribe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 2;
            label1.Text = "Welcome to the library";
            // 
            // btnaddbook
            // 
            btnaddbook.Location = new Point(42, 75);
            btnaddbook.Name = "btnaddbook";
            btnaddbook.Size = new Size(132, 56);
            btnaddbook.TabIndex = 3;
            btnaddbook.Text = "Add Book";
            btnaddbook.UseVisualStyleBackColor = true;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 178);
            Controls.Add(btnaddbook);
            Controls.Add(label1);
            Controls.Add(btnsubscribe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Off;
            Name = "frmWelcome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsubscribe;
        private Label label1;
        private Button btnaddbook;
    }
}