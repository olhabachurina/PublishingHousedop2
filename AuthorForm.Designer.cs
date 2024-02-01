namespace PublishingHousedop2
{
    partial class AuthorForm
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
            AuthorNameTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // AuthorNameTextBox
            // 
            AuthorNameTextBox.Location = new Point(0, 0);
            AuthorNameTextBox.Name = "AuthorNameTextBox";
            AuthorNameTextBox.Size = new Size(125, 27);
            AuthorNameTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 345);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 1;
            saveButton.Text = "save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click_1;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(AuthorNameTextBox);
            Name = "AuthorForm";
            Text = "AuthorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthorNameTextBox;
        private Button saveButton;
    }
}