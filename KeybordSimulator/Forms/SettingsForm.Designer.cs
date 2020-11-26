namespace KeybordSimulator.Forms
{
    partial class SettingsForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LevelsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EditLevelButton = new System.Windows.Forms.Button();
            this.DeleteLevelButton = new System.Windows.Forms.Button();
            this.AddNewLevelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(244, 29);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(30, 250);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SaveButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExitButton);
            this.splitContainer1.Size = new System.Drawing.Size(500, 35);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(3, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(240, 29);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Назад";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LevelsListBox
            // 
            this.LevelsListBox.FormattingEnabled = true;
            this.LevelsListBox.HorizontalScrollbar = true;
            this.LevelsListBox.Location = new System.Drawing.Point(12, 12);
            this.LevelsListBox.Name = "LevelsListBox";
            this.LevelsListBox.Size = new System.Drawing.Size(560, 173);
            this.LevelsListBox.TabIndex = 2;
            this.LevelsListBox.SelectedIndexChanged += new System.EventHandler(this.LevelsListBox_SelectedIndexChanged);
            this.LevelsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LevelsListBox_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.EditLevelButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteLevelButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddNewLevelButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 191);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // EditLevelButton
            // 
            this.EditLevelButton.Enabled = false;
            this.EditLevelButton.Location = new System.Drawing.Point(189, 3);
            this.EditLevelButton.Name = "EditLevelButton";
            this.EditLevelButton.Size = new System.Drawing.Size(180, 21);
            this.EditLevelButton.TabIndex = 2;
            this.EditLevelButton.Text = "Изменить уровень";
            this.EditLevelButton.UseVisualStyleBackColor = true;
            this.EditLevelButton.Click += new System.EventHandler(this.EditLevelButton_Click);
            // 
            // DeleteLevelButton
            // 
            this.DeleteLevelButton.Enabled = false;
            this.DeleteLevelButton.Location = new System.Drawing.Point(375, 3);
            this.DeleteLevelButton.Name = "DeleteLevelButton";
            this.DeleteLevelButton.Size = new System.Drawing.Size(182, 21);
            this.DeleteLevelButton.TabIndex = 1;
            this.DeleteLevelButton.Text = "Удалить уровень";
            this.DeleteLevelButton.UseVisualStyleBackColor = true;
            this.DeleteLevelButton.Click += new System.EventHandler(this.DeleteLevelButton_Click);
            // 
            // AddNewLevelButton
            // 
            this.AddNewLevelButton.Location = new System.Drawing.Point(3, 3);
            this.AddNewLevelButton.Name = "AddNewLevelButton";
            this.AddNewLevelButton.Size = new System.Drawing.Size(180, 21);
            this.AddNewLevelButton.TabIndex = 0;
            this.AddNewLevelButton.Text = "Добавить новый уровень";
            this.AddNewLevelButton.UseVisualStyleBackColor = true;
            this.AddNewLevelButton.Click += new System.EventHandler(this.AddNewLevelButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LevelsListBox);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox LevelsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EditLevelButton;
        private System.Windows.Forms.Button DeleteLevelButton;
        private System.Windows.Forms.Button AddNewLevelButton;
    }
}