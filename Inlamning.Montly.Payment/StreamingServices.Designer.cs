namespace Inlamning.Montly.Payment
{
    partial class StreamingServices
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
            CompanyListbox = new ListBox();
            AddChsnButton = new Button();
            ChosenListBox = new ListBox();
            label1 = new Label();
            KrMonthLabel = new Label();
            RmvCpnyButton = new Button();
            CompanyTextBox = new TextBox();
            CostTextBox = new TextBox();
            AddCompanyLabel = new Label();
            AddCostLabel = new Label();
            label4 = new Label();
            AddCpnyButton = new Button();
            UpdateButton = new Button();
            UpdateLabel = new Label();
            SuspendLayout();
            // 
            // StrmToMnuButton
            // 
            StrmToMnuButton.Location = new Point(719, 470);
            StrmToMnuButton.Name = "StrmToMnuButton";
            StrmToMnuButton.Size = new Size(158, 68);
            StrmToMnuButton.TabIndex = 0;
            StrmToMnuButton.Text = "Main menu";
            StrmToMnuButton.UseVisualStyleBackColor = true;
            StrmToMnuButton.Click += StrmToMnuButton_Click;
            // 
            // CompanyListbox
            // 
            CompanyListbox.FormattingEnabled = true;
            CompanyListbox.ItemHeight = 25;
            CompanyListbox.Location = new Point(17, 25);
            CompanyListbox.Name = "CompanyListbox";
            CompanyListbox.Size = new Size(264, 304);
            CompanyListbox.TabIndex = 1;
            // 
            // AddChsnButton
            // 
            AddChsnButton.Location = new Point(310, 174);
            AddChsnButton.Name = "AddChsnButton";
            AddChsnButton.Size = new Size(112, 34);
            AddChsnButton.TabIndex = 2;
            AddChsnButton.Text = "Add";
            AddChsnButton.UseMnemonic = false;
            AddChsnButton.UseVisualStyleBackColor = true;
            AddChsnButton.Click += AddChsnButton_Click;
            // 
            // ChosenListBox
            // 
            ChosenListBox.FormattingEnabled = true;
            ChosenListBox.ItemHeight = 25;
            ChosenListBox.Location = new Point(438, 25);
            ChosenListBox.Name = "ChosenListBox";
            ChosenListBox.Size = new Size(264, 304);
            ChosenListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 345);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 4;
            label1.Text = "Each month you pay:";
            // 
            // KrMonthLabel
            // 
            KrMonthLabel.AutoSize = true;
            KrMonthLabel.Location = new Point(609, 345);
            KrMonthLabel.Name = "KrMonthLabel";
            KrMonthLabel.Size = new Size(59, 25);
            KrMonthLabel.TabIndex = 5;
            KrMonthLabel.Text = "label2";
            KrMonthLabel.Visible = false;
            // 
            // RmvCpnyButton
            // 
            RmvCpnyButton.Location = new Point(310, 243);
            RmvCpnyButton.Name = "RmvCpnyButton";
            RmvCpnyButton.Size = new Size(112, 34);
            RmvCpnyButton.TabIndex = 6;
            RmvCpnyButton.Text = "Remove";
            RmvCpnyButton.UseVisualStyleBackColor = true;
            RmvCpnyButton.Click += RmvCpnyButton_Click;
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(107, 413);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(150, 31);
            CompanyTextBox.TabIndex = 7;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(107, 450);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(150, 31);
            CostTextBox.TabIndex = 8;
            // 
            // AddCompanyLabel
            // 
            AddCompanyLabel.AutoSize = true;
            AddCompanyLabel.Location = new Point(12, 413);
            AddCompanyLabel.Name = "AddCompanyLabel";
            AddCompanyLabel.Size = new Size(93, 25);
            AddCompanyLabel.TabIndex = 9;
            AddCompanyLabel.Text = "Company:";
            // 
            // AddCostLabel
            // 
            AddCostLabel.AutoSize = true;
            AddCostLabel.Location = new Point(53, 450);
            AddCostLabel.Name = "AddCostLabel";
            AddCostLabel.Size = new Size(52, 25);
            AddCostLabel.TabIndex = 10;
            AddCostLabel.Text = "Cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 368);
            label4.Name = "label4";
            label4.Size = new Size(259, 30);
            label4.TabIndex = 11;
            label4.Text = "Add missing service here:";
            // 
            // AddCpnyButton
            // 
            AddCpnyButton.Location = new Point(298, 413);
            AddCpnyButton.Name = "AddCpnyButton";
            AddCpnyButton.Size = new Size(158, 68);
            AddCpnyButton.TabIndex = 12;
            AddCpnyButton.Text = "Add Service";
            AddCpnyButton.UseVisualStyleBackColor = true;
            AddCpnyButton.Click += AddCpnyButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(719, 295);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(112, 34);
            UpdateButton.TabIndex = 13;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdateLabel
            // 
            UpdateLabel.AutoSize = true;
            UpdateLabel.Location = new Point(719, 345);
            UpdateLabel.Name = "UpdateLabel";
            UpdateLabel.Size = new Size(59, 25);
            UpdateLabel.TabIndex = 14;
            UpdateLabel.Text = "label2";
            UpdateLabel.Visible = false;
            // 
            // StreamingServices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(889, 564);
            Controls.Add(UpdateLabel);
            Controls.Add(UpdateButton);
            Controls.Add(AddCpnyButton);
            Controls.Add(label4);
            Controls.Add(AddCostLabel);
            Controls.Add(AddCompanyLabel);
            Controls.Add(CostTextBox);
            Controls.Add(CompanyTextBox);
            Controls.Add(RmvCpnyButton);
            Controls.Add(KrMonthLabel);
            Controls.Add(label1);
            Controls.Add(ChosenListBox);
            Controls.Add(AddChsnButton);
            Controls.Add(CompanyListbox);
            Controls.Add(StrmToMnuButton);
            Name = "StreamingServices";
            Text = "StreamingServices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StrmToMnuButton;
        private ListBox CompanyListbox;
        private Button AddChsnButton;
        private ListBox ChosenListBox;
        private Label label1;
        private Label KrMonthLabel;
        private Button RmvCpnyButton;
        private TextBox CompanyTextBox;
        private TextBox CostTextBox;
        private Label AddCompanyLabel;
        private Label AddCostLabel;
        private Label label4;
        private Button AddCpnyButton;
        private Button UpdateButton;
        private Label UpdateLabel;
    }
}