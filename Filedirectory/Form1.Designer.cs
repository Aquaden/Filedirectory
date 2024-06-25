namespace Filedirectory
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
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            btnCrFolder = new Button();
            label1 = new Label();
            txtFoldName = new TextBox();
            label2 = new Label();
            txtCrFilename = new TextBox();
            btnCreateFile = new Button();
            openFileDialog4 = new OpenFileDialog();
            label3 = new Label();
            txtWriteToFile = new TextBox();
            btnWriteFile = new Button();
            btnUpdFile = new Button();
            btnDeleteFile = new Button();
            btnReadFile = new Button();
            rctxtReadFile = new RichTextBox();
            openFileDialog5 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // btnCrFolder
            // 
            btnCrFolder.Location = new Point(127, 95);
            btnCrFolder.Name = "btnCrFolder";
            btnCrFolder.Size = new Size(137, 29);
            btnCrFolder.TabIndex = 0;
            btnCrFolder.Text = "Create_Folder";
            btnCrFolder.UseVisualStyleBackColor = true;
            btnCrFolder.Click += btnCrFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(127, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Name of Folder";
            // 
            // txtFoldName
            // 
            txtFoldName.Location = new Point(127, 51);
            txtFoldName.Name = "txtFoldName";
            txtFoldName.Size = new Size(125, 27);
            txtFoldName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(127, 170);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Name of File";
            // 
            // txtCrFilename
            // 
            txtCrFilename.Location = new Point(127, 204);
            txtCrFilename.Name = "txtCrFilename";
            txtCrFilename.Size = new Size(125, 27);
            txtCrFilename.TabIndex = 4;
            // 
            // btnCreateFile
            // 
            btnCreateFile.Location = new Point(127, 248);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(94, 29);
            btnCreateFile.TabIndex = 5;
            btnCreateFile.Text = "Create_File";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(438, 18);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 6;
            label3.Text = "Write to File";
            // 
            // txtWriteToFile
            // 
            txtWriteToFile.Location = new Point(438, 51);
            txtWriteToFile.Name = "txtWriteToFile";
            txtWriteToFile.Size = new Size(125, 27);
            txtWriteToFile.TabIndex = 7;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(438, 95);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(94, 29);
            btnWriteFile.TabIndex = 8;
            btnWriteFile.Text = "Write_File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnUpdFile
            // 
            btnUpdFile.Location = new Point(552, 95);
            btnUpdFile.Name = "btnUpdFile";
            btnUpdFile.Size = new Size(108, 29);
            btnUpdFile.TabIndex = 9;
            btnUpdFile.Text = "Update_File";
            btnUpdFile.UseVisualStyleBackColor = true;
            btnUpdFile.Click += btnUpdFile_Click;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(587, 383);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(201, 46);
            btnDeleteFile.TabIndex = 10;
            btnDeleteFile.Text = "Delete_File";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(427, 202);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(94, 29);
            btnReadFile.TabIndex = 11;
            btnReadFile.Text = "Read_File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // rctxtReadFile
            // 
            rctxtReadFile.Location = new Point(427, 248);
            rctxtReadFile.Name = "rctxtReadFile";
            rctxtReadFile.Size = new Size(125, 120);
            rctxtReadFile.TabIndex = 12;
            rctxtReadFile.Text = "";
            // 
            // openFileDialog5
            // 
            openFileDialog5.FileName = "openFileDialog5";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(rctxtReadFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnUpdFile);
            Controls.Add(btnWriteFile);
            Controls.Add(txtWriteToFile);
            Controls.Add(label3);
            Controls.Add(btnCreateFile);
            Controls.Add(txtCrFilename);
            Controls.Add(label2);
            Controls.Add(txtFoldName);
            Controls.Add(label1);
            Controls.Add(btnCrFolder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private Button btnCrFolder;
        private Label label1;
        private TextBox txtFoldName;
        private Label label2;
        private TextBox txtCrFilename;
        private Button btnCreateFile;
        private OpenFileDialog openFileDialog4;
        private Label label3;
        private TextBox txtWriteToFile;
        private Button btnWriteFile;
        private Button btnUpdFile;
        private Button btnDeleteFile;
        private Button btnReadFile;
        private RichTextBox rctxtReadFile;
        private OpenFileDialog openFileDialog5;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}