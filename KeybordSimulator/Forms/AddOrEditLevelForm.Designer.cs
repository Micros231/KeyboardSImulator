namespace KeybordSimulator.Forms
{
    partial class AddOrEditLevelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TimeMultiplierLabel = new System.Windows.Forms.Label();
            this.WordsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeMultiplierNumeric = new System.Windows.Forms.NumericUpDown();
            this.LevelNameTextBox = new System.Windows.Forms.TextBox();
            this.MinWordsNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxWordsNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinWordsLabel = new System.Windows.Forms.Label();
            this.MaxWordsLabel = new System.Windows.Forms.Label();
            this.WordsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.EditWordButton = new System.Windows.Forms.Button();
            this.DeleteWordButton = new System.Windows.Forms.Button();
            this.AddAndEditButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMultiplierNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWordsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWordsNumeric)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя уровня:";
            // 
            // TimeMultiplierLabel
            // 
            this.TimeMultiplierLabel.AutoSize = true;
            this.TimeMultiplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeMultiplierLabel.Location = new System.Drawing.Point(3, 24);
            this.TimeMultiplierLabel.Name = "TimeMultiplierLabel";
            this.TimeMultiplierLabel.Size = new System.Drawing.Size(164, 17);
            this.TimeMultiplierLabel.TabIndex = 1;
            this.TimeMultiplierLabel.Text = "Множитель времени:";
            // 
            // WordsLabel
            // 
            this.WordsLabel.AutoSize = true;
            this.WordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsLabel.Location = new System.Drawing.Point(15, 110);
            this.WordsLabel.Name = "WordsLabel";
            this.WordsLabel.Size = new System.Drawing.Size(58, 17);
            this.WordsLabel.TabIndex = 2;
            this.WordsLabel.Text = "Слова:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.TimeMultiplierNumeric, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LevelNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimeMultiplierLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MinWordsNumeric, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MaxWordsNumeric, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MinWordsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MaxWordsLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 95);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // TimeMultiplierNumeric
            // 
            this.TimeMultiplierNumeric.DecimalPlaces = 1;
            this.TimeMultiplierNumeric.Location = new System.Drawing.Point(199, 27);
            this.TimeMultiplierNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TimeMultiplierNumeric.Name = "TimeMultiplierNumeric";
            this.TimeMultiplierNumeric.Size = new System.Drawing.Size(120, 20);
            this.TimeMultiplierNumeric.TabIndex = 4;
            // 
            // LevelNameTextBox
            // 
            this.LevelNameTextBox.Location = new System.Drawing.Point(199, 3);
            this.LevelNameTextBox.Name = "LevelNameTextBox";
            this.LevelNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.LevelNameTextBox.TabIndex = 2;
            // 
            // MinWordsNumeric
            // 
            this.MinWordsNumeric.Location = new System.Drawing.Point(199, 75);
            this.MinWordsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinWordsNumeric.Name = "MinWordsNumeric";
            this.MinWordsNumeric.Size = new System.Drawing.Size(120, 20);
            this.MinWordsNumeric.TabIndex = 8;
            this.MinWordsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinWordsNumeric.ValueChanged += new System.EventHandler(this.MinWordsNumeric_ValueChanged);
            // 
            // MaxWordsNumeric
            // 
            this.MaxWordsNumeric.Location = new System.Drawing.Point(199, 51);
            this.MaxWordsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxWordsNumeric.Name = "MaxWordsNumeric";
            this.MaxWordsNumeric.Size = new System.Drawing.Size(120, 20);
            this.MaxWordsNumeric.TabIndex = 7;
            this.MaxWordsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxWordsNumeric.ValueChanged += new System.EventHandler(this.MaxWordsNumeric_ValueChanged);
            // 
            // MinWordsLabel
            // 
            this.MinWordsLabel.AutoSize = true;
            this.MinWordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinWordsLabel.Location = new System.Drawing.Point(3, 72);
            this.MinWordsLabel.Name = "MinWordsLabel";
            this.MinWordsLabel.Size = new System.Drawing.Size(178, 17);
            this.MinWordsLabel.TabIndex = 5;
            this.MinWordsLabel.Text = "Мин. количество слов:";
            // 
            // MaxWordsLabel
            // 
            this.MaxWordsLabel.AutoSize = true;
            this.MaxWordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxWordsLabel.Location = new System.Drawing.Point(3, 48);
            this.MaxWordsLabel.Name = "MaxWordsLabel";
            this.MaxWordsLabel.Size = new System.Drawing.Size(185, 17);
            this.MaxWordsLabel.TabIndex = 6;
            this.MaxWordsLabel.Text = "Макс. количество слов:";
            // 
            // WordsListBox
            // 
            this.WordsListBox.FormattingEnabled = true;
            this.WordsListBox.Location = new System.Drawing.Point(18, 130);
            this.WordsListBox.Name = "WordsListBox";
            this.WordsListBox.Size = new System.Drawing.Size(548, 95);
            this.WordsListBox.TabIndex = 4;
            this.WordsListBox.SelectedIndexChanged += new System.EventHandler(this.WordsListBox_SelectedIndexChanged);
            this.WordsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WordsListBox_MouseDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.AddWordButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditWordButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DeleteWordButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 231);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(548, 33);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // AddWordButton
            // 
            this.AddWordButton.Location = new System.Drawing.Point(3, 3);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(176, 27);
            this.AddWordButton.TabIndex = 0;
            this.AddWordButton.Text = "Добавить слово";
            this.AddWordButton.UseVisualStyleBackColor = true;
            this.AddWordButton.Click += new System.EventHandler(this.AddWord_Click);
            // 
            // EditWordButton
            // 
            this.EditWordButton.Location = new System.Drawing.Point(185, 3);
            this.EditWordButton.Name = "EditWordButton";
            this.EditWordButton.Size = new System.Drawing.Size(176, 27);
            this.EditWordButton.TabIndex = 1;
            this.EditWordButton.Text = "Изменить слово";
            this.EditWordButton.UseVisualStyleBackColor = true;
            this.EditWordButton.Click += new System.EventHandler(this.EditWord_Click);
            // 
            // DeleteWordButton
            // 
            this.DeleteWordButton.Location = new System.Drawing.Point(367, 3);
            this.DeleteWordButton.Name = "DeleteWordButton";
            this.DeleteWordButton.Size = new System.Drawing.Size(178, 27);
            this.DeleteWordButton.TabIndex = 2;
            this.DeleteWordButton.Text = "Удалить слово";
            this.DeleteWordButton.UseVisualStyleBackColor = true;
            this.DeleteWordButton.Click += new System.EventHandler(this.DeleteWord_Click);
            // 
            // AddAndEditButton
            // 
            this.AddAndEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AddAndEditButton.Location = new System.Drawing.Point(3, 3);
            this.AddAndEditButton.Name = "AddAndEditButton";
            this.AddAndEditButton.Size = new System.Drawing.Size(194, 24);
            this.AddAndEditButton.TabIndex = 3;
            this.AddAndEditButton.Text = "(Добавить/Изменить)";
            this.AddAndEditButton.UseVisualStyleBackColor = true;
            this.AddAndEditButton.Click += new System.EventHandler(this.AddAndEditButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(3, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(190, 24);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Назад";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(87, 269);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddAndEditButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExitButton);
            this.splitContainer1.Size = new System.Drawing.Size(400, 30);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 6;
            // 
            // AddOrEditLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.WordsListBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.WordsLabel);
            this.Name = "AddOrEditLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrEditLevelForm";
            this.Load += new System.EventHandler(this.AddOrEditLevelForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMultiplierNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWordsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWordsNumeric)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeMultiplierLabel;
        private System.Windows.Forms.Label WordsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown TimeMultiplierNumeric;
        private System.Windows.Forms.TextBox LevelNameTextBox;
        private System.Windows.Forms.ListBox WordsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.Button EditWordButton;
        private System.Windows.Forms.Button DeleteWordButton;
        private System.Windows.Forms.Button AddAndEditButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown MinWordsNumeric;
        private System.Windows.Forms.NumericUpDown MaxWordsNumeric;
        private System.Windows.Forms.Label MinWordsLabel;
        private System.Windows.Forms.Label MaxWordsLabel;
    }
}