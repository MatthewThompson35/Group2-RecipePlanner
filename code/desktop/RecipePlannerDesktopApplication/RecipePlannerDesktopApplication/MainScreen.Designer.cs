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
            this.label1 = new System.Windows.Forms.Label();
            this.errorNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(677, 261);
            this.nameButton.Margin = new System.Windows.Forms.Padding(4);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(100, 28);
            this.nameButton.TabIndex = 0;
            this.nameButton.Text = "Add";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(329, 264);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(289, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert a Name:";
            // 
            // errorNameLabel
            // 
            this.errorNameLabel.AutoSize = true;
            this.errorNameLabel.ForeColor = System.Drawing.Color.Red;
            this.errorNameLabel.Location = new System.Drawing.Point(332, 308);
            this.errorNameLabel.Name = "errorNameLabel";
            this.errorNameLabel.Size = new System.Drawing.Size(145, 16);
            this.errorNameLabel.TabIndex = 3;
            this.errorNameLabel.Text = "Please Insert a Name!!!";
            this.errorNameLabel.Visible = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.errorNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorNameLabel;
    }
}

