namespace KeybordSimulator.Forms
{
    partial class SupportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportForm));
            this.SupportTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SupportTextBox
            // 
            this.SupportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupportTextBox.Location = new System.Drawing.Point(12, 12);
            this.SupportTextBox.Multiline = true;
            this.SupportTextBox.Name = "SupportTextBox";
            this.SupportTextBox.ReadOnly = true;
            this.SupportTextBox.Size = new System.Drawing.Size(760, 284);
            this.SupportTextBox.TabIndex = 1;
            this.SupportTextBox.Text = resources.GetString("SupportTextBox.Text");
            this.SupportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 301);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(760, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Окей";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 336);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SupportTextBox);
            this.Name = "SupportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Помощь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SupportTextBox;
        private System.Windows.Forms.Button OKButton;
    }
}