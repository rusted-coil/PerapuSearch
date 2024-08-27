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
            groupBox1 = new GroupBox();
            m_Gen4SeedInputSupportButton = new Button();
            groupBox2 = new GroupBox();
            m_UsageLabel = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // m_SeedList
            // 
            m_SeedList.Font = new Font("Courier New", 11F);
            m_SeedList.Location = new Point(19, 26);
            m_SeedList.Margin = new Padding(3, 4, 3, 4);
            m_SeedList.Multiline = true;
            m_SeedList.Name = "m_SeedList";
            m_SeedList.ScrollBars = ScrollBars.Vertical;
            m_SeedList.Size = new Size(203, 225);
            m_SeedList.TabIndex = 10;
            m_SeedList.TextChanged += OnTextChanged;
            // 
            // m_ToneBox
            // 
            m_ToneBox.Font = new Font("Courier New", 11F);
            m_ToneBox.Location = new Point(15, 26);
            m_ToneBox.Margin = new Padding(3, 4, 3, 4);
            m_ToneBox.Multiline = true;
            m_ToneBox.Name = "m_ToneBox";
            m_ToneBox.ScrollBars = ScrollBars.Vertical;
            m_ToneBox.Size = new Size(625, 63);
            m_ToneBox.TabIndex = 11;
            m_ToneBox.TextChanged += OnTextChanged;
            // 
            // m_ResultBox
            // 
            m_ResultBox.Font = new Font("メイリオ", 9F);
            m_ResultBox.Location = new Point(19, 26);
            m_ResultBox.Margin = new Padding(3, 4, 3, 4);
            m_ResultBox.Multiline = true;
            m_ResultBox.Name = "m_ResultBox";
            m_ResultBox.ReadOnly = true;
            m_ResultBox.ScrollBars = ScrollBars.Vertical;
            m_ResultBox.Size = new Size(881, 224);
            m_ResultBox.TabIndex = 13;
            // 
            // m_Gen4Check
            // 
            m_Gen4Check.AutoSize = true;
            m_Gen4Check.Font = new Font("メイリオ", 9F);
            m_Gen4Check.Location = new Point(12, 14);
            m_Gen4Check.Margin = new Padding(3, 4, 3, 4);
            m_Gen4Check.Name = "m_Gen4Check";
            m_Gen4Check.Size = new Size(69, 22);
            m_Gen4Check.TabIndex = 0;
            m_Gen4Check.TabStop = true;
            m_Gen4Check.Text = "第4世代";
            m_Gen4Check.UseVisualStyleBackColor = true;
            m_Gen4Check.CheckedChanged += m_Gen4Check_CheckedChanged;
            // 
            // m_Gen5Check
            // 
            m_Gen5Check.AutoSize = true;
            m_Gen5Check.Font = new Font("メイリオ", 9F);
            m_Gen5Check.Location = new Point(85, 14);
            m_Gen5Check.Margin = new Padding(3, 4, 3, 4);
            m_Gen5Check.Name = "m_Gen5Check";
            m_Gen5Check.Size = new Size(69, 22);
            m_Gen5Check.TabIndex = 1;
            m_Gen5Check.TabStop = true;
            m_Gen5Check.Text = "第5世代";
            m_Gen5Check.UseVisualStyleBackColor = true;
            m_Gen5Check.CheckedChanged += m_Gen5Check_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 9F);
            label1.Location = new Point(168, 17);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 2;
            label1.Text = "開始位置:";
            // 
            // m_MinCountBox
            // 
            m_MinCountBox.Font = new Font("メイリオ", 9F);
            m_MinCountBox.Location = new Point(235, 13);
            m_MinCountBox.Margin = new Padding(3, 4, 3, 4);
            m_MinCountBox.Name = "m_MinCountBox";
            m_MinCountBox.Size = new Size(49, 25);
            m_MinCountBox.TabIndex = 3;
            m_MinCountBox.TextChanged += m_MinCountBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("メイリオ", 9F);
            label2.Location = new Point(290, 17);
            label2.Name = "label2";
            label2.Size = new Size(20, 18);
            label2.TabIndex = 4;
            label2.Text = "～";
            // 
            // m_MaxCountBox
            // 
            m_MaxCountBox.Font = new Font("メイリオ", 9F);
            m_MaxCountBox.Location = new Point(316, 13);
            m_MaxCountBox.Margin = new Padding(3, 4, 3, 4);
            m_MaxCountBox.Name = "m_MaxCountBox";
            m_MaxCountBox.Size = new Size(49, 25);
            m_MaxCountBox.TabIndex = 5;
            m_MaxCountBox.TextChanged += m_MaxCountBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("メイリオ", 9F);
            label3.Location = new Point(386, 17);
            label3.Name = "label3";
            label3.Size = new Size(71, 18);
            label3.TabIndex = 6;
            label3.Text = "曖昧さ[%]:";
            // 
            // m_FuzzinessBox
            // 
            m_FuzzinessBox.Font = new Font("メイリオ", 9F);
            m_FuzzinessBox.Location = new Point(461, 14);
            m_FuzzinessBox.Margin = new Padding(3, 4, 3, 4);
            m_FuzzinessBox.Name = "m_FuzzinessBox";
            m_FuzzinessBox.Size = new Size(49, 25);
            m_FuzzinessBox.TabIndex = 7;
            m_FuzzinessBox.TextChanged += m_FuzzinessBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("メイリオ", 9F);
            label4.Location = new Point(535, 17);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 8;
            label4.Text = "聴き分ける音の数:";
            // 
            // m_SampleCountBox
            // 
            m_SampleCountBox.Font = new Font("メイリオ", 9F);
            m_SampleCountBox.Location = new Point(649, 13);
            m_SampleCountBox.Margin = new Padding(3, 4, 3, 4);
            m_SampleCountBox.Name = "m_SampleCountBox";
            m_SampleCountBox.Size = new Size(49, 25);
            m_SampleCountBox.TabIndex = 9;
            m_SampleCountBox.TextChanged += m_SampleCountBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(m_Gen4SeedInputSupportButton);
            groupBox1.Controls.Add(m_SeedList);
            groupBox1.Font = new Font("メイリオ", 9F);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(235, 294);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "初期seed候補";
            // 
            // m_Gen4SeedInputSupportButton
            // 
            m_Gen4SeedInputSupportButton.Location = new Point(56, 258);
            m_Gen4SeedInputSupportButton.Name = "m_Gen4SeedInputSupportButton";
            m_Gen4SeedInputSupportButton.Size = new Size(123, 25);
            m_Gen4SeedInputSupportButton.TabIndex = 11;
            m_Gen4SeedInputSupportButton.Text = "第4世代入力補助";
            m_Gen4SeedInputSupportButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(m_UsageLabel);
            groupBox2.Controls.Add(m_ToneBox);
            groupBox2.Font = new Font("メイリオ", 9F);
            groupBox2.Location = new Point(272, 64);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(660, 294);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "入力";
            // 
            // m_UsageLabel
            // 
            m_UsageLabel.AutoSize = true;
            m_UsageLabel.Font = new Font("メイリオ", 9F);
            m_UsageLabel.Location = new Point(15, 108);
            m_UsageLabel.Name = "m_UsageLabel";
            m_UsageLabel.Size = new Size(44, 18);
            m_UsageLabel.TabIndex = 18;
            m_UsageLabel.Text = "使い方";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(m_ResultBox);
            groupBox3.Font = new Font("メイリオ", 9F);
            groupBox3.Location = new Point(12, 366);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(920, 267);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "結果";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 641);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            Font = new Font("メイリオ", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "ペラップ聞き分けツール - PerapuSearch";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox m_SeedList;
        private TextBox m_ToneBox;
        private TextBox m_ResultBox;
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label m_UsageLabel;
        private Button m_Gen4SeedInputSupportButton;
    }
}
