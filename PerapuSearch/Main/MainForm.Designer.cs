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
            label1 = new Label();
            m_MinCountBox = new TextBox();
            label2 = new Label();
            m_MaxCountBox = new TextBox();
            label3 = new Label();
            m_FuzzinessBox = new TextBox();
            label4 = new Label();
            m_SampleCountBox = new TextBox();
            SuspendLayout();
            // 
            // m_SeedList
            // 
            m_SeedList.Location = new Point(17, 104);
            m_SeedList.Multiline = true;
            m_SeedList.Name = "m_SeedList";
            m_SeedList.ScrollBars = ScrollBars.Vertical;
            m_SeedList.Size = new Size(215, 135);
            m_SeedList.TabIndex = 10;
            m_SeedList.TextChanged += OnTextChanged;
            // 
            // m_ToneBox
            // 
            m_ToneBox.Location = new Point(30, 323);
            m_ToneBox.Multiline = true;
            m_ToneBox.Name = "m_ToneBox";
            m_ToneBox.ScrollBars = ScrollBars.Vertical;
            m_ToneBox.Size = new Size(929, 81);
            m_ToneBox.TabIndex = 11;
            m_ToneBox.TextChanged += OnTextChanged;
            // 
            // m_ResultBox
            // 
            m_ResultBox.Location = new Point(17, 441);
            m_ResultBox.Multiline = true;
            m_ResultBox.Name = "m_ResultBox";
            m_ResultBox.ReadOnly = true;
            m_ResultBox.ScrollBars = ScrollBars.Vertical;
            m_ResultBox.Size = new Size(1092, 175);
            m_ResultBox.TabIndex = 13;
            // 
            // m_AnswerTones
            // 
            m_AnswerTones.Location = new Point(261, 74);
            m_AnswerTones.Multiline = true;
            m_AnswerTones.Name = "m_AnswerTones";
            m_AnswerTones.ReadOnly = true;
            m_AnswerTones.ScrollBars = ScrollBars.Vertical;
            m_AnswerTones.Size = new Size(848, 231);
            m_AnswerTones.TabIndex = 12;
            // 
            // m_Gen4Check
            // 
            m_Gen4Check.AutoSize = true;
            m_Gen4Check.Location = new Point(12, 12);
            m_Gen4Check.Name = "m_Gen4Check";
            m_Gen4Check.Size = new Size(67, 19);
            m_Gen4Check.TabIndex = 0;
            m_Gen4Check.TabStop = true;
            m_Gen4Check.Text = "第4世代";
            m_Gen4Check.UseVisualStyleBackColor = true;
            m_Gen4Check.CheckedChanged += m_Gen4Check_CheckedChanged;
            // 
            // m_Gen5Check
            // 
            m_Gen5Check.AutoSize = true;
            m_Gen5Check.Location = new Point(85, 12);
            m_Gen5Check.Name = "m_Gen5Check";
            m_Gen5Check.Size = new Size(67, 19);
            m_Gen5Check.TabIndex = 1;
            m_Gen5Check.TabStop = true;
            m_Gen5Check.Text = "第5世代";
            m_Gen5Check.UseVisualStyleBackColor = true;
            m_Gen5Check.CheckedChanged += m_Gen5Check_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "開始位置:";
            // 
            // m_MinCountBox
            // 
            m_MinCountBox.Location = new Point(232, 11);
            m_MinCountBox.Name = "m_MinCountBox";
            m_MinCountBox.Size = new Size(49, 23);
            m_MinCountBox.TabIndex = 3;
            m_MinCountBox.TextChanged += m_MinCountBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 14);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 4;
            label2.Text = "～";
            // 
            // m_MaxCountBox
            // 
            m_MaxCountBox.Location = new Point(312, 11);
            m_MaxCountBox.Name = "m_MaxCountBox";
            m_MaxCountBox.Size = new Size(49, 23);
            m_MaxCountBox.TabIndex = 5;
            m_MaxCountBox.TextChanged += m_MaxCountBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 14);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "あいまいさ:";
            // 
            // m_FuzzinessBox
            // 
            m_FuzzinessBox.Location = new Point(445, 11);
            m_FuzzinessBox.Name = "m_FuzzinessBox";
            m_FuzzinessBox.Size = new Size(49, 23);
            m_FuzzinessBox.TabIndex = 7;
            m_FuzzinessBox.TextChanged += m_FuzzinessBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 16);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "聴き分ける音の数:";
            // 
            // m_SampleCountBox
            // 
            m_SampleCountBox.Location = new Point(612, 13);
            m_SampleCountBox.Name = "m_SampleCountBox";
            m_SampleCountBox.Size = new Size(49, 23);
            m_SampleCountBox.TabIndex = 9;
            m_SampleCountBox.TextChanged += m_SampleCountBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 628);
            Controls.Add(m_SampleCountBox);
            Controls.Add(label4);
            Controls.Add(m_FuzzinessBox);
            Controls.Add(label3);
            Controls.Add(m_MaxCountBox);
            Controls.Add(label2);
            Controls.Add(m_MinCountBox);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox m_MinCountBox;
        private Label label2;
        private TextBox m_MaxCountBox;
        private Label label3;
        private TextBox m_FuzzinessBox;
        private Label label4;
        private TextBox m_SampleCountBox;
    }
}
