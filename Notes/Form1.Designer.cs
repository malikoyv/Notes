namespace Notes
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            noteBox = new TextBox();
            titleNote = new TextBox();
            titleLabel = new Label();
            yourNoteLabel = new Label();
            previousNotes = new DataGridView();
            loadButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            newButton = new Button();
            color = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // noteBox
            // 
            noteBox.Location = new Point(451, 167);
            noteBox.Margin = new Padding(3, 4, 3, 4);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(455, 387);
            noteBox.TabIndex = 0;
            // 
            // titleNote
            // 
            titleNote.Location = new Point(451, 81);
            titleNote.Margin = new Padding(3, 4, 3, 4);
            titleNote.Name = "titleNote";
            titleNote.Size = new Size(455, 27);
            titleNote.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(451, 36);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(456, 39);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            titleLabel.Click += Title_Click;
            // 
            // yourNoteLabel
            // 
            yourNoteLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            yourNoteLabel.Location = new Point(451, 116);
            yourNoteLabel.Name = "yourNoteLabel";
            yourNoteLabel.Size = new Size(456, 39);
            yourNoteLabel.TabIndex = 2;
            yourNoteLabel.Text = "Your note:";
            yourNoteLabel.TextAlign = ContentAlignment.MiddleLeft;
            yourNoteLabel.Click += Title_Click;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.Tan;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(14, 36);
            previousNotes.Margin = new Padding(3, 4, 3, 4);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 51;
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(431, 404);
            previousNotes.TabIndex = 3;
            previousNotes.CellContentClick += previousNotes_CellContentClick;
            // 
            // loadButton
            // 
            loadButton.BackColor = SystemColors.ButtonHighlight;
            loadButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(14, 448);
            loadButton.Margin = new Padding(3, 4, 3, 4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(210, 53);
            loadButton.TabIndex = 4;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ButtonHighlight;
            deleteButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(231, 448);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(214, 53);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ButtonHighlight;
            saveButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(231, 501);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(214, 53);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // newButton
            // 
            newButton.BackColor = SystemColors.ButtonHighlight;
            newButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            newButton.Location = new Point(14, 501);
            newButton.Margin = new Padding(3, 4, 3, 4);
            newButton.Name = "newButton";
            newButton.Size = new Size(210, 53);
            newButton.TabIndex = 4;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // color
            // 
            color.BackColor = SystemColors.HighlightText;
            color.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            color.Location = new Point(780, 12);
            color.Name = "color";
            color.Size = new Size(126, 47);
            color.TabIndex = 5;
            color.Text = "Color";
            color.UseVisualStyleBackColor = false;
            color.Click += color_Click;
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(921, 600);
            Controls.Add(color);
            Controls.Add(newButton);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(previousNotes);
            Controls.Add(yourNoteLabel);
            Controls.Add(titleLabel);
            Controls.Add(titleNote);
            Controls.Add(noteBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Notes";
            Text = "Yehor's Notes";
            Load += Notes_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox noteBox;
        private TextBox titleNote;
        private Label titleLabel;
        private Label yourNoteLabel;
        private DataGridView previousNotes;
        private Button loadButton;
        private Button deleteButton;
        private Button saveButton;
        private Button newButton;
        private Button color;
    }
}