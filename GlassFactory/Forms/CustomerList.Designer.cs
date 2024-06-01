namespace GlassFactory.Forms;

partial class CustomerList
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
        tableLayoutPanel1 = new TableLayoutPanel();
        dataGridView1 = new DataGridView();
        tableLayoutPanel3 = new TableLayoutPanel();
        nunberOfPagesmLabel = new Label();
        prevPageBtn = new Button();
        nextPageBtn = new Button();
        numericUpDown1 = new NumericUpDown();
        EmailLabel = new Label();
        NameLabel = new Label();
        EmailTextBox = new TextBox();
        NameTextBox = new TextBox();
        tableLayoutPanel2 = new TableLayoutPanel();
        IdTextBox = new TextBox();
        IdLabel = new Label();
        AddButton = new Button();
        NoteTextBox = new TextBox();
        NoteLabel = new Label();
        PhoneTextBox = new TextBox();
        PhoneLabel = new Label();
        ClearButton = new Button();
        tableLayoutPanel4 = new TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        tableLayoutPanel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel1.Location = new Point(12, 42);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(587, 521);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.BackgroundColor = SystemColors.Control;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(3, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.Size = new Size(581, 428);
        dataGridView1.TabIndex = 2;
        dataGridView1.CellClick += dataGridView1_CellClick;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel3.ColumnCount = 4;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tableLayoutPanel3.Controls.Add(nunberOfPagesmLabel, 2, 0);
        tableLayoutPanel3.Controls.Add(prevPageBtn, 0, 0);
        tableLayoutPanel3.Controls.Add(nextPageBtn, 3, 0);
        tableLayoutPanel3.Controls.Add(numericUpDown1, 1, 0);
        tableLayoutPanel3.Location = new Point(3, 437);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle());
        tableLayoutPanel3.Size = new Size(581, 81);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // nunberOfPagesmLabel
        // 
        nunberOfPagesmLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        nunberOfPagesmLabel.Font = new Font("Segoe UI", 11F);
        nunberOfPagesmLabel.Location = new Point(293, 22);
        nunberOfPagesmLabel.Name = "nunberOfPagesmLabel";
        nunberOfPagesmLabel.Size = new Size(52, 37);
        nunberOfPagesmLabel.TabIndex = 15;
        nunberOfPagesmLabel.Text = "label1";
        nunberOfPagesmLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // prevPageBtn
        // 
        prevPageBtn.Anchor = AnchorStyles.Right;
        prevPageBtn.Location = new Point(185, 23);
        prevPageBtn.Name = "prevPageBtn";
        prevPageBtn.Size = new Size(44, 35);
        prevPageBtn.TabIndex = 3;
        prevPageBtn.Text = "<";
        prevPageBtn.UseVisualStyleBackColor = true;
        prevPageBtn.Click += prevPageBtn_Click;
        // 
        // nextPageBtn
        // 
        nextPageBtn.Anchor = AnchorStyles.Left;
        nextPageBtn.Location = new Point(351, 23);
        nextPageBtn.Name = "nextPageBtn";
        nextPageBtn.Size = new Size(44, 35);
        nextPageBtn.TabIndex = 16;
        nextPageBtn.Text = ">";
        nextPageBtn.UseVisualStyleBackColor = true;
        nextPageBtn.Click += nextPageBtn_Click;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        numericUpDown1.Location = new Point(235, 29);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(52, 23);
        numericUpDown1.TabIndex = 17;
        // 
        // EmailLabel
        // 
        EmailLabel.Anchor = AnchorStyles.Left;
        EmailLabel.AutoSize = true;
        EmailLabel.Location = new Point(3, 65);
        EmailLabel.Name = "EmailLabel";
        EmailLabel.Size = new Size(36, 15);
        EmailLabel.TabIndex = 12;
        EmailLabel.Text = "Email";
        // 
        // NameLabel
        // 
        NameLabel.Anchor = AnchorStyles.Left;
        NameLabel.AutoSize = true;
        NameLabel.Location = new Point(3, 36);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(39, 15);
        NameLabel.TabIndex = 11;
        NameLabel.Text = "Name";
        // 
        // EmailTextBox
        // 
        EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        EmailTextBox.Location = new Point(97, 61);
        EmailTextBox.Name = "EmailTextBox";
        EmailTextBox.Size = new Size(228, 23);
        EmailTextBox.TabIndex = 9;
        // 
        // NameTextBox
        // 
        NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NameTextBox.Location = new Point(97, 32);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(228, 23);
        NameTextBox.TabIndex = 8;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 5);
        tableLayoutPanel2.Controls.Add(IdTextBox, 1, 0);
        tableLayoutPanel2.Controls.Add(IdLabel, 0, 0);
        tableLayoutPanel2.Controls.Add(NoteTextBox, 1, 4);
        tableLayoutPanel2.Controls.Add(NoteLabel, 0, 4);
        tableLayoutPanel2.Controls.Add(NameLabel, 0, 1);
        tableLayoutPanel2.Controls.Add(PhoneTextBox, 1, 3);
        tableLayoutPanel2.Controls.Add(PhoneLabel, 0, 3);
        tableLayoutPanel2.Controls.Add(EmailLabel, 0, 2);
        tableLayoutPanel2.Controls.Add(NameTextBox, 1, 1);
        tableLayoutPanel2.Controls.Add(EmailTextBox, 1, 2);
        tableLayoutPanel2.Location = new Point(630, 42);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 6;
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.Size = new Size(325, 281);
        tableLayoutPanel2.TabIndex = 14;
        // 
        // IdTextBox
        // 
        IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        IdTextBox.Enabled = false;
        IdTextBox.Location = new Point(97, 3);
        IdTextBox.Name = "IdTextBox";
        IdTextBox.Size = new Size(228, 23);
        IdTextBox.TabIndex = 17;
        // 
        // IdLabel
        // 
        IdLabel.Anchor = AnchorStyles.Left;
        IdLabel.AutoSize = true;
        IdLabel.Location = new Point(3, 7);
        IdLabel.Name = "IdLabel";
        IdLabel.Size = new Size(17, 15);
        IdLabel.TabIndex = 16;
        IdLabel.Text = "Id";
        // 
        // AddButton
        // 
        AddButton.Anchor = AnchorStyles.Right;
        AddButton.Location = new Point(140, 6);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(85, 33);
        AddButton.TabIndex = 7;
        AddButton.Text = "+ Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // NoteTextBox
        // 
        NoteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NoteTextBox.Location = new Point(97, 119);
        NoteTextBox.Multiline = true;
        NoteTextBox.Name = "NoteTextBox";
        NoteTextBox.Size = new Size(228, 111);
        NoteTextBox.TabIndex = 15;
        // 
        // NoteLabel
        // 
        NoteLabel.AutoSize = true;
        NoteLabel.Location = new Point(3, 116);
        NoteLabel.Name = "NoteLabel";
        NoteLabel.Size = new Size(33, 15);
        NoteLabel.TabIndex = 14;
        NoteLabel.Text = "Note";
        // 
        // PhoneTextBox
        // 
        PhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        PhoneTextBox.Location = new Point(97, 90);
        PhoneTextBox.Name = "PhoneTextBox";
        PhoneTextBox.Size = new Size(228, 23);
        PhoneTextBox.TabIndex = 10;
        // 
        // PhoneLabel
        // 
        PhoneLabel.Anchor = AnchorStyles.Left;
        PhoneLabel.AutoSize = true;
        PhoneLabel.Location = new Point(3, 94);
        PhoneLabel.Name = "PhoneLabel";
        PhoneLabel.Size = new Size(88, 15);
        PhoneLabel.TabIndex = 13;
        PhoneLabel.Text = "Phone Number";
        // 
        // ClearButton
        // 
        ClearButton.Anchor = AnchorStyles.Right;
        ClearButton.Location = new Point(44, 6);
        ClearButton.Name = "ClearButton";
        ClearButton.Size = new Size(85, 33);
        ClearButton.TabIndex = 15;
        ClearButton.Text = "Clear";
        ClearButton.UseVisualStyleBackColor = true;
        ClearButton.Click += ClearButton_Click;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        tableLayoutPanel4.ColumnCount = 2;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
        tableLayoutPanel4.Controls.Add(AddButton, 1, 0);
        tableLayoutPanel4.Controls.Add(ClearButton, 0, 0);
        tableLayoutPanel4.Location = new Point(97, 236);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle());
        tableLayoutPanel4.Size = new Size(228, 45);
        tableLayoutPanel4.TabIndex = 16;
        // 
        // CustomerList
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(994, 575);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(tableLayoutPanel2);
        Name = "CustomerList";
        Text = "0";
        Load += CustomerList_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        tableLayoutPanel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private TableLayoutPanel tableLayoutPanel1;
    private Label EmailLabel;
    private Label NameLabel;
    private TextBox EmailTextBox;
    private TextBox NameTextBox;
    private TableLayoutPanel tableLayoutPanel2;
    private Button prevPageBtn;
    private TextBox PhoneTextBox;
    private Label PhoneLabel;
    private Label nunberOfPagesmLabel;
    private TableLayoutPanel tableLayoutPanel3;
    private Button nextPageBtn;
    private TextBox NoteTextBox;
    private Label NoteLabel;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    private TextBox IdTextBox;
    private Label IdLabel;
    private Button AddButton;
    private NumericUpDown numericUpDown1;
    private Button ClearButton;
    private TableLayoutPanel tableLayoutPanel4;
}