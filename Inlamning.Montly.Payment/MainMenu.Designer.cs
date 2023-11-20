namespace Inlamning.Montly.Payment
{
    partial class MainMenu
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
            MainMenuLabel = new Label();
            ChooseButton = new Button();
            CalculateButton = new Button();
            QuitButton = new Button();
            ChooseLabel = new Label();
            CalculateLabel = new Label();
            CurrentLabel = new Label();
            CostLabel = new Label();
            UpdateCostButton = new Button();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            fiLeToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            SaveStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            LoadedLabel = new Label();
            LoadedCostLabel = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuLabel
            // 
            MainMenuLabel.AutoSize = true;
            MainMenuLabel.Font = new Font("Rockwell", 22F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuLabel.Location = new Point(274, 62);
            MainMenuLabel.Name = "MainMenuLabel";
            MainMenuLabel.Size = new Size(246, 49);
            MainMenuLabel.TabIndex = 0;
            MainMenuLabel.Text = "Main Menu";
            // 
            // ChooseButton
            // 
            ChooseButton.BackColor = SystemColors.ButtonFace;
            ChooseButton.Location = new Point(85, 288);
            ChooseButton.Name = "ChooseButton";
            ChooseButton.Size = new Size(140, 59);
            ChooseButton.TabIndex = 1;
            ChooseButton.Text = "See Services";
            ChooseButton.UseVisualStyleBackColor = false;
            ChooseButton.Click += ChooseButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = SystemColors.ButtonFace;
            CalculateButton.Location = new Point(85, 420);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(140, 59);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Estimate Costs";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = SystemColors.ButtonFace;
            QuitButton.Location = new Point(85, 535);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(192, 105);
            QuitButton.TabIndex = 4;
            QuitButton.Text = "Quit Program";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // ChooseLabel
            // 
            ChooseLabel.AutoSize = true;
            ChooseLabel.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseLabel.Location = new Point(85, 260);
            ChooseLabel.Name = "ChooseLabel";
            ChooseLabel.Size = new Size(181, 25);
            ChooseLabel.TabIndex = 5;
            ChooseLabel.Text = "Choose services";
            // 
            // CalculateLabel
            // 
            CalculateLabel.AutoSize = true;
            CalculateLabel.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateLabel.Location = new Point(85, 392);
            CalculateLabel.Name = "CalculateLabel";
            CalculateLabel.Size = new Size(294, 25);
            CalculateLabel.TabIndex = 6;
            CalculateLabel.Text = "Estimate Monthly Payments";
            // 
            // CurrentLabel
            // 
            CurrentLabel.AutoSize = true;
            CurrentLabel.Font = new Font("Rockwell Nova Cond", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentLabel.Location = new Point(516, 552);
            CurrentLabel.Name = "CurrentLabel";
            CurrentLabel.Size = new Size(99, 30);
            CurrentLabel.TabIndex = 8;
            CurrentLabel.Text = "Current cost:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(610, 555);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(59, 25);
            CostLabel.TabIndex = 9;
            CostLabel.Text = "label1";
            CostLabel.Visible = false;
            // 
            // UpdateCostButton
            // 
            UpdateCostButton.Location = new Point(516, 585);
            UpdateCostButton.Name = "UpdateCostButton";
            UpdateCostButton.Size = new Size(125, 38);
            UpdateCostButton.TabIndex = 10;
            UpdateCostButton.Text = "Update";
            UpdateCostButton.UseVisualStyleBackColor = true;
            UpdateCostButton.Click += UpdateCostButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(757, 25);
            label1.TabIndex = 11;
            label1.Text = "Welcome! With the help of this program, you can keep track of your monthly expenses.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 649);
            label2.Name = "label2";
            label2.Size = new Size(201, 21);
            label2.TabIndex = 12;
            label2.Text = "Program done: 2023-11-16";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fiLeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(807, 33);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fiLeToolStripMenuItem
            // 
            fiLeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, SaveStripMenuItem });
            fiLeToolStripMenuItem.Name = "fiLeToolStripMenuItem";
            fiLeToolStripMenuItem.Size = new Size(54, 29);
            fiLeToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(153, 34);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // SaveStripMenuItem
            // 
            SaveStripMenuItem.Name = "SaveStripMenuItem";
            SaveStripMenuItem.Size = new Size(153, 34);
            SaveStripMenuItem.Text = "Save";
            SaveStripMenuItem.Click += SaveStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(489, 230);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(215, 179);
            listBox1.TabIndex = 14;
            listBox1.Visible = false;
            // 
            // LoadedLabel
            // 
            LoadedLabel.AutoSize = true;
            LoadedLabel.Location = new Point(489, 420);
            LoadedLabel.Name = "LoadedLabel";
            LoadedLabel.Size = new Size(143, 25);
            LoadedLabel.TabIndex = 15;
            LoadedLabel.Text = "Cost per/month:";
            LoadedLabel.Visible = false;
            // 
            // LoadedCostLabel
            // 
            LoadedCostLabel.AutoSize = true;
            LoadedCostLabel.Location = new Point(628, 420);
            LoadedCostLabel.Name = "LoadedCostLabel";
            LoadedCostLabel.Size = new Size(59, 25);
            LoadedCostLabel.TabIndex = 16;
            LoadedCostLabel.Text = "label3";
            LoadedCostLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(469, 199);
            label3.Name = "label3";
            label3.Size = new Size(256, 28);
            label3.TabIndex = 17;
            label3.Text = "Your latest list of services";
            label3.Visible = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(807, 679);
            Controls.Add(label3);
            Controls.Add(LoadedCostLabel);
            Controls.Add(LoadedLabel);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateCostButton);
            Controls.Add(CostLabel);
            Controls.Add(CurrentLabel);
            Controls.Add(CalculateLabel);
            Controls.Add(ChooseLabel);
            Controls.Add(QuitButton);
            Controls.Add(CalculateButton);
            Controls.Add(ChooseButton);
            Controls.Add(MainMenuLabel);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "MainMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainMenuLabel;
        private Button ChooseButton;
        private Button CalculateButton;
        private Button QuitButton;
        private Label ChooseLabel;
        private Label CalculateLabel;
        private Label CurrentLabel;
        private Label CostLabel;
        private Button UpdateCostButton;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fiLeToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem SaveStripMenuItem;
        private ListBox listBox1;
        private Label LoadedLabel;
        private Label LoadedCostLabel;
        private Label label3;
    }
}