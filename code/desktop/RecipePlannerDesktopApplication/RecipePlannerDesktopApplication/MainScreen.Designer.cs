namespace RecipePlannerDesktopApplication
{
    partial class MainScreen
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
            this.nameButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(567, 212);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 0;
            this.nameButton.Text = "Add";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(321, 206);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameButton);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

