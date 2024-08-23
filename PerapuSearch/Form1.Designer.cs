namespace PerapuSearch
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
            SeedList = new TextBox();
            ToneBox = new TextBox();
            ResultBox = new TextBox();
            SuspendLayout();
            // 
            // SeedList
            // 
            SeedList.Location = new Point(17, 15);
            SeedList.Multiline = true;
            SeedList.Name = "SeedList";
            SeedList.Size = new Size(215, 135);
            SeedList.TabIndex = 0;
            SeedList.TextChanged += Calculate;
            // 
            // ToneBox
            // 
            ToneBox.Location = new Point(267, 15);
            ToneBox.Multiline = true;
            ToneBox.Name = "ToneBox";
            ToneBox.Size = new Size(372, 135);
            ToneBox.TabIndex = 1;
            ToneBox.TextChanged += Calculate;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(17, 211);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(771, 135);
            ResultBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultBox);
            Controls.Add(ToneBox);
            Controls.Add(SeedList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SeedList;
        private TextBox ToneBox;
        private TextBox ResultBox;
    }
}
