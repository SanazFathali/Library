namespace WinFormsApp1
{
    partial class FrmSubscriber
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lblName = new Label();
            txtName = new TextBox();
            LblLastName = new Label();
            lblCellphone = new Label();
            lblCode = new Label();
            txtLastName = new TextBox();
            txtCellphone = new TextBox();
            txtcode = new TextBox();
            btnSave = new Button();
            btnShow = new Button();
            btnClear = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(666, 170);
            dataGridView1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 2;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // LblLastName
            // 
            LblLastName.AutoSize = true;
            LblLastName.Location = new Point(27, 72);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(51, 15);
            LblLastName.TabIndex = 3;
            LblLastName.Text = "Lastame";
            // 
            // lblCellphone
            // 
            lblCellphone.AutoSize = true;
            lblCellphone.Location = new Point(27, 121);
            lblCellphone.Name = "lblCellphone";
            lblCellphone.Size = new Size(61, 15);
            lblCellphone.TabIndex = 4;
            lblCellphone.Text = "Cellphone";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.BackColor = Color.Transparent;
            lblCode.Location = new Point(27, 168);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(35, 15);
            lblCode.TabIndex = 5;
            lblCode.Text = "Code";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(216, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtCellphone
            // 
            txtCellphone.Location = new Point(112, 117);
            txtCellphone.Name = "txtCellphone";
            txtCellphone.Size = new Size(216, 23);
            txtCellphone.TabIndex = 7;
            txtCellphone.KeyPress += txtCellphone_KeyPress;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(112, 164);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(216, 23);
            txtcode.TabIndex = 8;
            txtcode.KeyPress += txtcode_KeyPress;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(439, 17);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 37);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(439, 60);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(206, 37);
            btnShow.TabIndex = 10;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(439, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(206, 37);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(439, 146);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(206, 37);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmSubscriber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 382);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(btnSave);
            Controls.Add(txtcode);
            Controls.Add(txtCellphone);
            Controls.Add(txtLastName);
            Controls.Add(lblCode);
            Controls.Add(lblCellphone);
            Controls.Add(LblLastName);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmSubscriber";
            ShowIcon = false;
            Text = "FrmSubscriber";
            Load += FrmSubscriber_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblName;
        private TextBox txtName;
        private Label LblLastName;
        private Label lblCellphone;
        private Label lblCode;
        private TextBox txtLastName;
        private TextBox txtCellphone;
        private TextBox txtcode;
        private Button btnSave;
        private Button btnShow;
        private Button btnClear;
        private Button btnExit;
    }
}