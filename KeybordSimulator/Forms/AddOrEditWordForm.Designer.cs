namespace KeybordSimulator.Forms
{
    partial class AddOrEditWordForm
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
            this.WordLabel = new System.Windows.Forms.Label();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.AddOrEditWordButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLabel.Location = new System.Drawing.Point(37, 30);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(58, 17);
            this.WordLabel.TabIndex = 0;
            this.WordLabel.Text = "Слово:";
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(40, 50);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(300, 20);
            this.WordTextBox.TabIndex = 1;
            this.WordTextBox.TextChanged += new System.EventHandler(this.WordTextBox_TextChanged);
            // 
            // AddOrEditWordButton
            // 
            this.AddOrEditWordButton.Location = new System.Drawing.Point(40, 76);
            this.AddOrEditWordButton.Name = "AddOrEditWordButton";
            this.AddOrEditWordButton.Size = new System.Drawing.Size(154, 23);
            this.AddOrEditWordButton.TabIndex = 2;
            this.AddOrEditWordButton.Text = "(Добавить/Изменить)";
            this.AddOrEditWordButton.UseVisualStyleBackColor = true;
            this.AddOrEditWordButton.Click += new System.EventHandler(this.AddOrEditWordButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(200, 76);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Отменить";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddOrEditWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddOrEditWordButton);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.WordLabel);
            this.Name = "AddOrEditWordForm";
            this.Text = "AddOrEditWordForm";
            this.Load += new System.EventHandler(this.AddOrEditWordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Button AddOrEditWordButton;
        private System.Windows.Forms.Button ExitButton;
    }
}