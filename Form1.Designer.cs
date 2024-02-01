namespace PublishingHousedop2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddAuthorButton = new Button();
            EditAuthorButton = new Button();
            DeleteAuthor = new Button();
            SuspendLayout();
            // 
            // AddAuthorButton
            // 
            AddAuthorButton.Location = new Point(12, 223);
            AddAuthorButton.Name = "AddAuthorButton";
            AddAuthorButton.Size = new Size(94, 29);
            AddAuthorButton.TabIndex = 0;
            AddAuthorButton.Text = "Add";
            AddAuthorButton.UseVisualStyleBackColor = true;
            AddAuthorButton.Click += Addbutton_Click;
            // 
            // EditAuthorButton
            // 
            EditAuthorButton.Location = new Point(12, 267);
            EditAuthorButton.Name = "EditAuthorButton";
            EditAuthorButton.Size = new Size(94, 29);
            EditAuthorButton.TabIndex = 1;
            EditAuthorButton.Text = "edit";
            EditAuthorButton.UseVisualStyleBackColor = true;
            EditAuthorButton.Click += EditAuthorButton_Click_1;
            // 
            // DeleteAuthor
            // 
            DeleteAuthor.Location = new Point(12, 320);
            DeleteAuthor.Name = "DeleteAuthor";
            DeleteAuthor.Size = new Size(94, 29);
            DeleteAuthor.TabIndex = 2;
            DeleteAuthor.Text = "DeleteAuthor";
            DeleteAuthor.UseVisualStyleBackColor = true;
            DeleteAuthor.Click += DeleteAuthor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteAuthor);
            Controls.Add(EditAuthorButton);
            Controls.Add(AddAuthorButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button AddAuthorButton;
        private Button EditAuthorButton;
        private Button DeleteAuthor;
    }
}
