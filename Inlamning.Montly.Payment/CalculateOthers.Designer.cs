namespace Inlamning.Montly.Payment
{
    partial class CalculateOthers
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
            StrmToMnuButton = new Button();
            IncomeLabel = new Label();
            label2 = new Label();
            GoalLabel = new Label();
            IncomeTxtBox = new TextBox();
            GoalTxtBox = new TextBox();
            listBox1 = new ListBox();
            label4 = new Label();
            CostCalcLabel = new Label();
            AddCostsButton = new Button();
            RemoveButton = new Button();
            label1 = new Label();
            financialGoalLabel = new Label();
            TimePeriodNumeric = new NumericUpDown();
            label3 = new Label();
            CalcTotButton = new Button();
            MoneyLeftLabel = new Label();
            label5 = new Label();
            label7 = new Label();
            ErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)TimePeriodNumeric).BeginInit();
            SuspendLayout();
            // 
            // StrmToMnuButton
            // 
            StrmToMnuButton.Location = new Point(693, 445);
            StrmToMnuButton.Name = "StrmToMnuButton";
            StrmToMnuButton.Size = new Size(158, 68);
            StrmToMnuButton.TabIndex = 1;
            StrmToMnuButton.Text = "Main menu";
            StrmToMnuButton.UseVisualStyleBackColor = true;
            StrmToMnuButton.Click += StrmToMnuButton_Click;
            // 
            // IncomeLabel
            // 
            IncomeLabel.AutoSize = true;
            IncomeLabel.Location = new Point(52, 192);
            IncomeLabel.Name = "IncomeLabel";
            IncomeLabel.Size = new Size(80, 25);
            IncomeLabel.TabIndex = 2;
            IncomeLabel.Text = "Income :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 3;
            label2.Text = "Financial Goal :";
            // 
            // GoalLabel
            // 
            GoalLabel.AutoSize = true;
            GoalLabel.Location = new Point(33, 122);
            GoalLabel.Name = "GoalLabel";
            GoalLabel.Size = new Size(0, 25);
            GoalLabel.TabIndex = 4;
            // 
            // IncomeTxtBox
            // 
            IncomeTxtBox.Location = new Point(158, 189);
            IncomeTxtBox.Name = "IncomeTxtBox";
            IncomeTxtBox.PlaceholderText = "Montly income...";
            IncomeTxtBox.Size = new Size(203, 31);
            IncomeTxtBox.TabIndex = 5;
            // 
            // GoalTxtBox
            // 
            GoalTxtBox.Location = new Point(158, 94);
            GoalTxtBox.Name = "GoalTxtBox";
            GoalTxtBox.PlaceholderText = "How much to save...";
            GoalTxtBox.Size = new Size(203, 31);
            GoalTxtBox.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(587, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(264, 279);
            listBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(587, 367);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 8;
            label4.Text = "Total costs:";
            // 
            // CostCalcLabel
            // 
            CostCalcLabel.AutoSize = true;
            CostCalcLabel.Location = new Point(683, 367);
            CostCalcLabel.Name = "CostCalcLabel";
            CostCalcLabel.Size = new Size(59, 25);
            CostCalcLabel.TabIndex = 9;
            CostCalcLabel.Text = "label5";
            CostCalcLabel.Visible = false;
            // 
            // AddCostsButton
            // 
            AddCostsButton.Location = new Point(429, 195);
            AddCostsButton.Name = "AddCostsButton";
            AddCostsButton.Size = new Size(152, 68);
            AddCostsButton.TabIndex = 10;
            AddCostsButton.Text = "Add";
            AddCostsButton.UseVisualStyleBackColor = true;
            AddCostsButton.Click += AddCostsButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(429, 269);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(152, 68);
            RemoveButton.TabIndex = 11;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 167);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 12;
            // 
            // financialGoalLabel
            // 
            financialGoalLabel.AutoSize = true;
            financialGoalLabel.Location = new Point(73, 291);
            financialGoalLabel.Name = "financialGoalLabel";
            financialGoalLabel.Size = new Size(59, 25);
            financialGoalLabel.TabIndex = 13;
            financialGoalLabel.Text = "label3";
            financialGoalLabel.Visible = false;
            // 
            // TimePeriodNumeric
            // 
            TimePeriodNumeric.Location = new Point(158, 142);
            TimePeriodNumeric.Name = "TimePeriodNumeric";
            TimePeriodNumeric.Size = new Size(203, 31);
            TimePeriodNumeric.TabIndex = 14;
            TimePeriodNumeric.ValueChanged += TimePeriodNumeric_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 142);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 15;
            label3.Text = "Months :";
            // 
            // CalcTotButton
            // 
            CalcTotButton.Location = new Point(158, 226);
            CalcTotButton.Name = "CalcTotButton";
            CalcTotButton.Size = new Size(112, 34);
            CalcTotButton.TabIndex = 16;
            CalcTotButton.Text = "Calculate";
            CalcTotButton.UseVisualStyleBackColor = true;
            CalcTotButton.Click += CalcTotButton_Click;
            // 
            // MoneyLeftLabel
            // 
            MoneyLeftLabel.AutoSize = true;
            MoneyLeftLabel.Location = new Point(211, 329);
            MoneyLeftLabel.Name = "MoneyLeftLabel";
            MoneyLeftLabel.Size = new Size(59, 25);
            MoneyLeftLabel.TabIndex = 17;
            MoneyLeftLabel.Text = "label5";
            MoneyLeftLabel.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 329);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 18;
            label5.Text = "Money Left/month:";
            label5.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(122, 54);
            label7.Name = "label7";
            label7.Size = new Size(224, 28);
            label7.TabIndex = 20;
            label7.Text = "Financial goal in months";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(139, 398);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(59, 25);
            ErrorLabel.TabIndex = 21;
            ErrorLabel.Text = "label3";
            ErrorLabel.Visible = false;
            // 
            // CalculateOthers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(876, 541);
            Controls.Add(ErrorLabel);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(MoneyLeftLabel);
            Controls.Add(CalcTotButton);
            Controls.Add(label3);
            Controls.Add(TimePeriodNumeric);
            Controls.Add(financialGoalLabel);
            Controls.Add(label1);
            Controls.Add(RemoveButton);
            Controls.Add(AddCostsButton);
            Controls.Add(CostCalcLabel);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(GoalTxtBox);
            Controls.Add(IncomeTxtBox);
            Controls.Add(GoalLabel);
            Controls.Add(label2);
            Controls.Add(IncomeLabel);
            Controls.Add(StrmToMnuButton);
            Name = "CalculateOthers";
            Text = "CalculateOthers";
            ((System.ComponentModel.ISupportInitialize)TimePeriodNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StrmToMnuButton;
        private Label IncomeLabel;
        private Label label2;
        private Label GoalLabel;
        private TextBox IncomeTxtBox;
        private TextBox GoalTxtBox;
        private ListBox listBox1;
        private Label label4;
        private Label CostCalcLabel;
        private Button AddCostsButton;
        private Button RemoveButton;
        private Label label1;
        private Label financialGoalLabel;
        private NumericUpDown TimePeriodNumeric;
        private Label label3;
        private Button CalcTotButton;
        private Label MoneyLeftLabel;
        private Label label5;
        private Label label7;
        private Label ErrorLabel;
    }
}