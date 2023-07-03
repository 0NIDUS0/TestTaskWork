namespace WorkTestProject
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
            listBoxTitles = new ListBox();
            SuspendLayout();
            // 
            // listBoxTitles
            // 
            listBoxTitles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxTitles.FormattingEnabled = true;
            listBoxTitles.ItemHeight = 21;
            listBoxTitles.Location = new Point(13, 13);
            listBoxTitles.Name = "listBoxTitles";
            listBoxTitles.Size = new Size(359, 424);
            listBoxTitles.TabIndex = 0;
            listBoxTitles.MouseDoubleClick += listBoxTitles_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 450);
            Controls.Add(listBoxTitles);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTitles;
    }
}