namespace KeybordSimulator.Forms
{
    partial class SimulatorForm
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
            this.components = new System.ComponentModel.Container();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.WordsLabel = new System.Windows.Forms.Label();
            this.EnterCharsLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.NeedLineLabel = new System.Windows.Forms.Label();
            this.EnterLineLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TimerControl = new System.Windows.Forms.Timer(this.components);
            this.TimeCountLabel = new System.Windows.Forms.Label();
            this.ErrorCountLabel = new System.Windows.Forms.Label();
            this.SpeedCountLabel = new System.Windows.Forms.Label();
            this.LevelNameLabel = new System.Windows.Forms.Label();
            this.WordCountLabel = new System.Windows.Forms.Label();
            this.PauseOrResumeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ErrorLabel.Location = new System.Drawing.Point(20, 80);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(68, 17);
            this.ErrorLabel.TabIndex = 1;
            this.ErrorLabel.Text = "Ошибки:";
            // 
            // WordsLabel
            // 
            this.WordsLabel.AutoSize = true;
            this.WordsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.WordsLabel.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.WordsLabel.Location = new System.Drawing.Point(380, 80);
            this.WordsLabel.Name = "WordsLabel";
            this.WordsLabel.Size = new System.Drawing.Size(49, 17);
            this.WordsLabel.TabIndex = 5;
            this.WordsLabel.Text = "Слов:";
            // 
            // EnterCharsLabel
            // 
            this.EnterCharsLabel.AutoSize = true;
            this.EnterCharsLabel.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.EnterCharsLabel.Location = new System.Drawing.Point(20, 180);
            this.EnterCharsLabel.Name = "EnterCharsLabel";
            this.EnterCharsLabel.Size = new System.Drawing.Size(130, 17);
            this.EnterCharsLabel.TabIndex = 3;
            this.EnterCharsLabel.Text = "Введите строку:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SpeedLabel.Location = new System.Drawing.Point(20, 130);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(139, 17);
            this.SpeedLabel.TabIndex = 2;
            this.SpeedLabel.Text = "Скорость набора:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LevelLabel.Location = new System.Drawing.Point(380, 30);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(75, 17);
            this.LevelLabel.TabIndex = 4;
            this.LevelLabel.Text = "Уровень:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(20, 30);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(58, 17);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Время:";
            // 
            // NeedLineLabel
            // 
            this.NeedLineLabel.AutoSize = true;
            this.NeedLineLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NeedLineLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.NeedLineLabel.Location = new System.Drawing.Point(3, 18);
            this.NeedLineLabel.Name = "NeedLineLabel";
            this.NeedLineLabel.Size = new System.Drawing.Size(60, 16);
            this.NeedLineLabel.TabIndex = 6;
            this.NeedLineLabel.Text = "(строка)";
            // 
            // EnterLineLabel
            // 
            this.EnterLineLabel.AutoSize = true;
            this.EnterLineLabel.BackColor = System.Drawing.SystemColors.Window;
            this.EnterLineLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.EnterLineLabel.Location = new System.Drawing.Point(3, 13);
            this.EnterLineLabel.Name = "EnterLineLabel";
            this.EnterLineLabel.Size = new System.Drawing.Size(48, 16);
            this.EnterLineLabel.TabIndex = 8;
            this.EnterLineLabel.Text = "(ввод)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 230);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.NeedLineLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Controls.Add(this.EnterLineLabel);
            this.splitContainer1.Size = new System.Drawing.Size(649, 99);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 9;
            // 
            // TimerControl
            // 
            this.TimerControl.Enabled = true;
            this.TimerControl.Interval = 1000;
            this.TimerControl.Tick += new System.EventHandler(this.TimerControl_Tick);
            // 
            // TimeCountLabel
            // 
            this.TimeCountLabel.AutoSize = true;
            this.TimeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeCountLabel.Location = new System.Drawing.Point(84, 30);
            this.TimeCountLabel.Name = "TimeCountLabel";
            this.TimeCountLabel.Size = new System.Drawing.Size(65, 17);
            this.TimeCountLabel.TabIndex = 10;
            this.TimeCountLabel.Text = "(время)";
            // 
            // ErrorCountLabel
            // 
            this.ErrorCountLabel.AutoSize = true;
            this.ErrorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorCountLabel.Location = new System.Drawing.Point(94, 81);
            this.ErrorCountLabel.Name = "ErrorCountLabel";
            this.ErrorCountLabel.Size = new System.Drawing.Size(76, 17);
            this.ErrorCountLabel.TabIndex = 11;
            this.ErrorCountLabel.Text = "(ошибки)";
            // 
            // SpeedCountLabel
            // 
            this.SpeedCountLabel.AutoSize = true;
            this.SpeedCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedCountLabel.Location = new System.Drawing.Point(165, 130);
            this.SpeedCountLabel.Name = "SpeedCountLabel";
            this.SpeedCountLabel.Size = new System.Drawing.Size(146, 17);
            this.SpeedCountLabel.TabIndex = 12;
            this.SpeedCountLabel.Text = "(скорость набора)";
            // 
            // LevelNameLabel
            // 
            this.LevelNameLabel.AutoSize = true;
            this.LevelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelNameLabel.Location = new System.Drawing.Point(461, 31);
            this.LevelNameLabel.Name = "LevelNameLabel";
            this.LevelNameLabel.Size = new System.Drawing.Size(80, 17);
            this.LevelNameLabel.TabIndex = 13;
            this.LevelNameLabel.Text = "(уровень)";
            // 
            // WordCountLabel
            // 
            this.WordCountLabel.AutoSize = true;
            this.WordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordCountLabel.Location = new System.Drawing.Point(435, 81);
            this.WordCountLabel.Name = "WordCountLabel";
            this.WordCountLabel.Size = new System.Drawing.Size(54, 17);
            this.WordCountLabel.TabIndex = 14;
            this.WordCountLabel.Text = "(слов)";
            // 
            // PauseOrResumeButton
            // 
            this.PauseOrResumeButton.Location = new System.Drawing.Point(383, 130);
            this.PauseOrResumeButton.Name = "PauseOrResumeButton";
            this.PauseOrResumeButton.Size = new System.Drawing.Size(289, 23);
            this.PauseOrResumeButton.TabIndex = 15;
            this.PauseOrResumeButton.Text = "(возобновить/пауза)";
            this.PauseOrResumeButton.UseVisualStyleBackColor = true;
            this.PauseOrResumeButton.Click += new System.EventHandler(this.PauseOrResumeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(383, 180);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(289, 23);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PauseOrResumeButton);
            this.Controls.Add(this.WordCountLabel);
            this.Controls.Add(this.LevelNameLabel);
            this.Controls.Add(this.SpeedCountLabel);
            this.Controls.Add(this.ErrorCountLabel);
            this.Controls.Add(this.TimeCountLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.EnterCharsLabel);
            this.Controls.Add(this.WordsLabel);
            this.Controls.Add(this.ErrorLabel);
            this.KeyPreview = true;
            this.Name = "SimulatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обучение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulatorForm_FormClosing);
            this.Load += new System.EventHandler(this.SimulatorForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label WordsLabel;
        private System.Windows.Forms.Label EnterCharsLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label NeedLineLabel;
        private System.Windows.Forms.Label EnterLineLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer TimerControl;
        private System.Windows.Forms.Label TimeCountLabel;
        private System.Windows.Forms.Label ErrorCountLabel;
        private System.Windows.Forms.Label SpeedCountLabel;
        private System.Windows.Forms.Label LevelNameLabel;
        private System.Windows.Forms.Label WordCountLabel;
        private System.Windows.Forms.Button PauseOrResumeButton;
        private System.Windows.Forms.Button ExitButton;
    }
}