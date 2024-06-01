namespace GlassFactory
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
            AddButton = new Button();
            NameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            NameLabel = new Label();
            EmailLabel = new Label();
            PhoneLabel = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(461, 244);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 0;
            AddButton.Text = "+ Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(188, 104);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(151, 23);
            NameTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(188, 146);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(151, 23);
            EmailTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(188, 191);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(151, 23);
            PhoneTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(58, 112);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(58, 154);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "Email";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(58, 199);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(88, 15);
            PhoneLabel.TabIndex = 6;
            PhoneLabel.Text = "Phone Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 338);
            Controls.Add(PhoneLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(AddButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox NameTextBox;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private Label NameLabel;
        private Label EmailLabel;
        private Label PhoneLabel;
    }
}
