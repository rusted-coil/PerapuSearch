namespace PerapuSearch
{
    partial class MainForm
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
            m_SeedList = new TextBox();
            m_ToneBox = new TextBox();
            m_ResultBox = new TextBox();
            m_AnswerTones = new TextBox();
            m_Gen4Check = new RadioButton();
            m_Gen5Check = new RadioButton();
            SuspendLayout();
            // 
            // m_SeedList
            // 
            m_SeedList.Location = new Point(17, 104);
            m_SeedList.Multiline = true;
            m_SeedList.Name = "m_SeedList";
            m_SeedList.Size = new Size(215, 135);
            m_SeedList.TabIndex = 0;
            m_SeedList.TextChanged += OnTextChanged;
            // 
            // m_ToneBox
            // 
            m_ToneBox.Location = new Point(30, 323);
            m_ToneBox.Multiline = true;
            m_ToneBox.Name = "m_ToneBox";
            m_ToneBox.Size = new Size(929, 81);
            m_ToneBox.TabIndex = 1;
            m_ToneBox.TextChanged += OnTextChanged;
            // 
            // m_ResultBox
            // 
            m_ResultBox.Location = new Point(17, 441);
            m_ResultBox.Multiline = true;
            m_ResultBox.Name = "m_ResultBox";
            m_ResultBox.ReadOnly = true;
            m_ResultBox.Size = new Size(1092, 175);
            m_ResultBox.TabIndex = 2;
            // 
            // m_AnswerTones
            // 
            m_AnswerTones.Location = new Point(261, 74);
            m_AnswerTones.Multiline = true;
            m_AnswerTones.Name = "m_AnswerTones";
            m_AnswerTones.ReadOnly = true;
            m_AnswerTones.Size = new Size(848, 231);
            m_AnswerTones.TabIndex = 3;
            // 
            // m_Gen4Check
            // 
            m_Gen4Check.AutoSize = true;
            m_Gen4Check.Location = new Point(12, 12);
            m_Gen4Check.Name = "m_Gen4Check";
            m_Gen4Check.Size = new Size(67, 19);
            m_Gen4Check.TabIndex = 4;
            m_Gen4Check.TabStop = true;
            m_Gen4Check.Text = "第4世代";
            m_Gen4Check.UseVisualStyleBackColor = true;
            // 
            // m_Gen5Check
            // 
            m_Gen5Check.AutoSize = true;
            m_Gen5Check.Location = new Point(85, 12);
            m_Gen5Check.Name = "m_Gen5Check";
            m_Gen5Check.Size = new Size(67, 19);
            m_Gen5Check.TabIndex = 5;
            m_Gen5Check.TabStop = true;
            m_Gen5Check.Text = "第5世代";
            m_Gen5Check.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 628);
            Controls.Add(m_Gen5Check);
            Controls.Add(m_Gen4Check);
            Controls.Add(m_AnswerTones);
            Controls.Add(m_ResultBox);
            Controls.Add(m_ToneBox);
            Controls.Add(m_SeedList);
            Name = "MainForm";
            Text = "ペラップ聞き分けツール - PerapuSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox m_SeedList;
        private TextBox m_ToneBox;
        private TextBox m_ResultBox;
        private TextBox m_AnswerTones;
        private RadioButton m_Gen4Check;
        private RadioButton m_Gen5Check;
    }
}
