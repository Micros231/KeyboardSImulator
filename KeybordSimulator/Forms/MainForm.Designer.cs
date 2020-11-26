namespace KeybordSimulator.Forms
{
    partial class MainForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 53);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(219, 36);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(109, 13);
            this.LevelLabel.TabIndex = 2;
            this.LevelLabel.Text = "Уровень сложности";
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelComboBox.Location = new System.Drawing.Point(222, 52);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(150, 21);
            this.LevelComboBox.TabIndex = 3;
            this.LevelComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelComboBox_SelectedIndexChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 91);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(360, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Начать тренировку";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 120);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(360, 23);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.Location = new System.Drawing.Point(12, 149);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(360, 23);
            this.SupportButton.TabIndex = 6;
            this.SupportButton.Text = "Помощь";
            this.SupportButton.UseVisualStyleBackColor = true;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 178);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(360, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SupportButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LevelComboBox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клавиатурный тренажер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button SupportButton;
        private System.Windows.Forms.Button ExitButton;
    }
}