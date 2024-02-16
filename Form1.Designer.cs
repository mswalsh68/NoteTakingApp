namespace NoteTakingApp
{
    partial class NoteTaker
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
            titleBox = new TextBox();
            notesBox = new TextBox();
            titleLabel = new Label();
            noteLabel = new Label();
            previousNotes = new DataGridView();
            loadButton = new Button();
            deleteButton = new Button();
            newNoteButton = new Button();
            savebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(421, 61);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(468, 30);
            titleBox.TabIndex = 0;
            // 
            // notesBox
            // 
            notesBox.Location = new Point(421, 130);
            notesBox.Multiline = true;
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(468, 614);
            notesBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(421, 21);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(468, 29);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            // 
            // noteLabel
            // 
            noteLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noteLabel.Location = new Point(421, 98);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(468, 29);
            noteLabel.TabIndex = 3;
            noteLabel.Text = "Note:";
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.White;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(12, 21);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 51;
            previousNotes.Size = new Size(393, 600);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(12, 627);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(201, 57);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(219, 627);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(186, 56);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.Location = new Point(12, 690);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(201, 54);
            newNoteButton.TabIndex = 7;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = true;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // savebutton
            // 
            savebutton.Location = new Point(219, 689);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(186, 55);
            savebutton.TabIndex = 8;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(902, 758);
            Controls.Add(savebutton);
            Controls.Add(newNoteButton);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(previousNotes);
            Controls.Add(noteLabel);
            Controls.Add(titleLabel);
            Controls.Add(notesBox);
            Controls.Add(titleBox);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox notesBox;
        private Label titleLabel;
        private Label noteLabel;
        private DataGridView previousNotes;
        private Button loadButton;
        private Button deleteButton;
        private Button newNoteButton;
        private Button savebutton;
    }
}
