namespace hw_10._06__Child_Parent_
{
    partial class Parent
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
            parentTextBox = new TextBox();
            SuspendLayout();
            // 
            // parentTextBox
            // 
            parentTextBox.BackColor = SystemColors.Highlight;
            parentTextBox.ForeColor = Color.White;
            parentTextBox.Location = new Point(12, 12);
            parentTextBox.Multiline = true;
            parentTextBox.Name = "parentTextBox";
            parentTextBox.Size = new Size(333, 66);
            parentTextBox.TabIndex = 0;
            parentTextBox.KeyUp += ParentTextBox_KeyUp;
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(357, 88);
            Controls.Add(parentTextBox);
            Name = "Parent";
            Text = "Parent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox parentTextBox;
    }
}