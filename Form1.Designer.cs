namespace SimpleCalculator
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
            LayoutPanel = new TableLayoutPanel();
            MathPercent = new Button();
            Math1 = new Button();
            Math2 = new Button();
            Math3 = new Button();
            Math4 = new Button();
            Math5 = new Button();
            Math6 = new Button();
            Math7 = new Button();
            Math8 = new Button();
            Math9 = new Button();
            MathMultiply = new Button();
            MathMinus = new Button();
            MathPlus = new Button();
            MathEquals = new Button();
            Math0 = new Button();
            MathClear = new Button();
            MathDivide = new Button();
            MathBackspace = new Button();
            HelpButton = new Button();
            MathDot = new Button();
            MathResult = new Label();
            MathTypeLabel = new Label();
            LayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LayoutPanel
            // 
            LayoutPanel.ColumnCount = 5;
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutPanel.Controls.Add(Math1, 0, 2);
            LayoutPanel.Controls.Add(Math2, 1, 2);
            LayoutPanel.Controls.Add(HelpButton, 3, 2);
            LayoutPanel.Controls.Add(MathBackspace, 2, 3);
            LayoutPanel.Controls.Add(Math3, 2, 2);
            LayoutPanel.Controls.Add(Math4, 0, 1);
            LayoutPanel.Controls.Add(Math5, 1, 1);
            LayoutPanel.Controls.Add(Math6, 2, 1);
            LayoutPanel.Controls.Add(Math0, 1, 3);
            LayoutPanel.Controls.Add(MathDot, 0, 3);
            LayoutPanel.Controls.Add(Math9, 2, 0);
            LayoutPanel.Controls.Add(Math8, 1, 0);
            LayoutPanel.Controls.Add(Math7, 0, 0);
            LayoutPanel.Controls.Add(MathEquals, 4, 3);
            LayoutPanel.Controls.Add(MathPlus, 4, 2);
            LayoutPanel.Controls.Add(MathMinus, 4, 1);
            LayoutPanel.Controls.Add(MathMultiply, 4, 0);
            LayoutPanel.Controls.Add(MathDivide, 3, 0);
            LayoutPanel.Controls.Add(MathClear, 3, 3);
            LayoutPanel.Controls.Add(MathPercent, 3, 1);
            LayoutPanel.Location = new Point(12, 42);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.RowCount = 4;
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999981F));
            LayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0000038F));
            LayoutPanel.Size = new Size(310, 207);
            LayoutPanel.TabIndex = 0;
            LayoutPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // MathPercent
            // 
            MathPercent.Location = new Point(189, 54);
            MathPercent.Name = "MathPercent";
            MathPercent.Size = new Size(56, 45);
            MathPercent.TabIndex = 3;
            MathPercent.Text = "%";
            MathPercent.UseVisualStyleBackColor = true;
            MathPercent.Click += MathPercent_Click;
            // 
            // Math1
            // 
            Math1.Font = new Font("Segoe UI", 12F);
            Math1.Location = new Point(3, 105);
            Math1.Name = "Math1";
            Math1.Size = new Size(56, 45);
            Math1.TabIndex = 1;
            Math1.Text = "1";
            Math1.UseVisualStyleBackColor = true;
            Math1.Click += NumberButtonClick;
            // 
            // Math2
            // 
            Math2.Font = new Font("Segoe UI", 12F);
            Math2.Location = new Point(65, 105);
            Math2.Name = "Math2";
            Math2.Size = new Size(56, 45);
            Math2.TabIndex = 2;
            Math2.Text = "2";
            Math2.UseVisualStyleBackColor = true;
            Math2.Click += NumberButtonClick;
            // 
            // Math3
            // 
            Math3.Font = new Font("Segoe UI", 12F);
            Math3.Location = new Point(127, 105);
            Math3.Name = "Math3";
            Math3.Size = new Size(56, 45);
            Math3.TabIndex = 3;
            Math3.Text = "3";
            Math3.UseVisualStyleBackColor = true;
            Math3.Click += NumberButtonClick;
            // 
            // Math4
            // 
            Math4.Font = new Font("Segoe UI", 12F);
            Math4.Location = new Point(3, 54);
            Math4.Name = "Math4";
            Math4.Size = new Size(56, 45);
            Math4.TabIndex = 4;
            Math4.Text = "4";
            Math4.UseVisualStyleBackColor = true;
            Math4.Click += NumberButtonClick;
            // 
            // Math5
            // 
            Math5.Font = new Font("Segoe UI", 12F);
            Math5.Location = new Point(65, 54);
            Math5.Name = "Math5";
            Math5.Size = new Size(56, 45);
            Math5.TabIndex = 5;
            Math5.Text = "5";
            Math5.UseVisualStyleBackColor = true;
            Math5.Click += NumberButtonClick;
            // 
            // Math6
            // 
            Math6.Font = new Font("Segoe UI", 12F);
            Math6.Location = new Point(127, 54);
            Math6.Name = "Math6";
            Math6.Size = new Size(56, 45);
            Math6.TabIndex = 6;
            Math6.Text = "6";
            Math6.UseVisualStyleBackColor = true;
            Math6.Click += NumberButtonClick;
            // 
            // Math7
            // 
            Math7.Font = new Font("Segoe UI", 12F);
            Math7.Location = new Point(3, 3);
            Math7.Name = "Math7";
            Math7.Size = new Size(56, 45);
            Math7.TabIndex = 7;
            Math7.Text = "7";
            Math7.UseVisualStyleBackColor = true;
            Math7.Click += NumberButtonClick;
            // 
            // Math8
            // 
            Math8.Font = new Font("Segoe UI", 12F);
            Math8.Location = new Point(65, 3);
            Math8.Name = "Math8";
            Math8.Size = new Size(56, 45);
            Math8.TabIndex = 8;
            Math8.Text = "8";
            Math8.UseVisualStyleBackColor = true;
            Math8.Click += NumberButtonClick;
            // 
            // Math9
            // 
            Math9.Font = new Font("Segoe UI", 12F);
            Math9.Location = new Point(127, 3);
            Math9.Name = "Math9";
            Math9.Size = new Size(56, 45);
            Math9.TabIndex = 9;
            Math9.Text = "9";
            Math9.UseVisualStyleBackColor = true;
            Math9.Click += NumberButtonClick;
            // 
            // MathMultiply
            // 
            MathMultiply.Font = new Font("Segoe UI", 12F);
            MathMultiply.Location = new Point(251, 3);
            MathMultiply.Name = "MathMultiply";
            MathMultiply.Size = new Size(56, 45);
            MathMultiply.TabIndex = 10;
            MathMultiply.Text = "X";
            MathMultiply.UseVisualStyleBackColor = true;
            MathMultiply.Click += MathOperatorHandler;
            // 
            // MathMinus
            // 
            MathMinus.Font = new Font("Segoe UI", 12F);
            MathMinus.Location = new Point(251, 54);
            MathMinus.Name = "MathMinus";
            MathMinus.Size = new Size(56, 45);
            MathMinus.TabIndex = 11;
            MathMinus.Text = "-";
            MathMinus.UseVisualStyleBackColor = true;
            MathMinus.Click += MathOperatorHandler;
            // 
            // MathPlus
            // 
            MathPlus.Font = new Font("Segoe UI", 12F);
            MathPlus.Location = new Point(251, 105);
            MathPlus.Name = "MathPlus";
            MathPlus.Size = new Size(56, 45);
            MathPlus.TabIndex = 12;
            MathPlus.Text = "+";
            MathPlus.UseVisualStyleBackColor = true;
            MathPlus.Click += MathOperatorHandler;
            // 
            // MathEquals
            // 
            MathEquals.Font = new Font("Segoe UI", 12F);
            MathEquals.Location = new Point(251, 156);
            MathEquals.Name = "MathEquals";
            MathEquals.Size = new Size(56, 48);
            MathEquals.TabIndex = 13;
            MathEquals.Text = "=";
            MathEquals.UseVisualStyleBackColor = true;
            MathEquals.Click += MathEquals_Click;
            // 
            // Math0
            // 
            Math0.Font = new Font("Segoe UI", 12F);
            Math0.Location = new Point(65, 156);
            Math0.Name = "Math0";
            Math0.Size = new Size(56, 48);
            Math0.TabIndex = 15;
            Math0.Text = "0";
            Math0.UseVisualStyleBackColor = true;
            Math0.Click += NumberButtonClick;
            // 
            // MathClear
            // 
            MathClear.Font = new Font("Segoe UI", 12F);
            MathClear.Location = new Point(189, 156);
            MathClear.Name = "MathClear";
            MathClear.Size = new Size(56, 48);
            MathClear.TabIndex = 16;
            MathClear.Text = "Clear";
            MathClear.UseVisualStyleBackColor = true;
            MathClear.Click += MathClear_Click;
            // 
            // MathDivide
            // 
            MathDivide.Font = new Font("Segoe UI", 12F);
            MathDivide.Location = new Point(189, 3);
            MathDivide.Name = "MathDivide";
            MathDivide.Size = new Size(56, 45);
            MathDivide.TabIndex = 17;
            MathDivide.Text = "/";
            MathDivide.UseVisualStyleBackColor = true;
            MathDivide.Click += MathOperatorHandler;
            // 
            // MathBackspace
            // 
            MathBackspace.Font = new Font("Segoe UI", 12F);
            MathBackspace.Location = new Point(127, 156);
            MathBackspace.Name = "MathBackspace";
            MathBackspace.Size = new Size(56, 48);
            MathBackspace.TabIndex = 18;
            MathBackspace.Text = "<--|";
            MathBackspace.UseVisualStyleBackColor = true;
            MathBackspace.Click += MathBackspace_Click;
            // 
            // HelpButton
            // 
            HelpButton.Font = new Font("Segoe UI", 12F);
            HelpButton.Location = new Point(189, 105);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(56, 45);
            HelpButton.TabIndex = 19;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // MathDot
            // 
            MathDot.Font = new Font("Segoe UI", 12F);
            MathDot.Location = new Point(3, 156);
            MathDot.Name = "MathDot";
            MathDot.Size = new Size(56, 48);
            MathDot.TabIndex = 14;
            MathDot.Text = ".";
            MathDot.UseVisualStyleBackColor = true;
            MathDot.Click += MathDot_Click;
            // 
            // MathResult
            // 
            MathResult.AutoSize = true;
            MathResult.BorderStyle = BorderStyle.FixedSingle;
            MathResult.Location = new Point(12, 9);
            MathResult.MaximumSize = new Size(250, 30);
            MathResult.MinimumSize = new Size(250, 30);
            MathResult.Name = "MathResult";
            MathResult.Size = new Size(250, 30);
            MathResult.TabIndex = 1;
            MathResult.Click += MathResult_Click;
            // 
            // MathTypeLabel
            // 
            MathTypeLabel.BorderStyle = BorderStyle.FixedSingle;
            MathTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MathTypeLabel.Location = new Point(268, 9);
            MathTypeLabel.MaximumSize = new Size(30, 30);
            MathTypeLabel.MinimumSize = new Size(30, 30);
            MathTypeLabel.Name = "MathTypeLabel";
            MathTypeLabel.Size = new Size(30, 30);
            MathTypeLabel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 261);
            Controls.Add(MathTypeLabel);
            Controls.Add(MathResult);
            Controls.Add(LayoutPanel);
            MaximumSize = new Size(350, 300);
            MinimumSize = new Size(350, 300);
            Name = "Form1";
            Text = "Calculator - Made By Odegard";
            Load += Form1_Load;
            LayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel LayoutPanel;
        private Button Math1;
        private Button Math2;
        private Button Math3;
        private Button Math4;
        private Button Math5;
        private Button Math6;
        private Button Math7;
        private Button Math8;
        private Button Math9;
        private Button MathMultiply;
        private Button MathMinus;
        private Button MathPlus;
        private Button MathEquals;
        private Button MathDot;
        private Button Math0;
        private Button MathClear;
        private Button MathDivide;
        private Button MathBackspace;
        private Button HelpButton;
        private Label MathResult;
        private Label MathTypeLabel;
        private Button MathPercent;
    }
}
