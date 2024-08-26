namespace PerapuSearch.Gen4SeedInputSupport.Internal
{
    internal partial class Gen4SeedInputSupportForm
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
            label1 = new Label();
            m_InitialSeedBox = new TextBox();
            m_SecondsDiffCheck = new CheckBox();
            label2 = new Label();
            m_FrameDiffRangeBox = new NumericUpDown();
            m_InputButton = new Button();
            m_OnlyEvenDiffCheck = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)m_FrameDiffRangeBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 18);
            label1.TabIndex = 0;
            label1.Text = "狙う初期seed: 0x";
            // 
            // m_InitialSeedBox
            // 
            m_InitialSeedBox.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m_InitialSeedBox.Location = new Point(115, 6);
            m_InitialSeedBox.Name = "m_InitialSeedBox";
            m_InitialSeedBox.Size = new Size(147, 24);
            m_InitialSeedBox.TabIndex = 1;
            // 
            // m_SecondsDiffCheck
            // 
            m_SecondsDiffCheck.AutoSize = true;
            m_SecondsDiffCheck.Font = new Font("メイリオ", 9F);
            m_SecondsDiffCheck.Location = new Point(15, 46);
            m_SecondsDiffCheck.Name = "m_SecondsDiffCheck";
            m_SecondsDiffCheck.Size = new Size(99, 22);
            m_SecondsDiffCheck.TabIndex = 2;
            m_SecondsDiffCheck.Text = "秒ズレを考慮";
            m_SecondsDiffCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 3;
            label2.Text = "フレームズレ±";
            // 
            // m_FrameDiffRangeBox
            // 
            m_FrameDiffRangeBox.Location = new Point(99, 84);
            m_FrameDiffRangeBox.Name = "m_FrameDiffRangeBox";
            m_FrameDiffRangeBox.Size = new Size(38, 23);
            m_FrameDiffRangeBox.TabIndex = 5;
            m_FrameDiffRangeBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // m_InputButton
            // 
            m_InputButton.Location = new Point(86, 119);
            m_InputButton.Name = "m_InputButton";
            m_InputButton.Size = new Size(93, 25);
            m_InputButton.TabIndex = 6;
            m_InputButton.Text = "入力";
            m_InputButton.UseVisualStyleBackColor = true;
            m_InputButton.Click += m_InputButton_Click;
            // 
            // m_OnlyEvenDiffCheck
            // 
            m_OnlyEvenDiffCheck.AutoSize = true;
            m_OnlyEvenDiffCheck.Checked = true;
            m_OnlyEvenDiffCheck.CheckState = CheckState.Checked;
            m_OnlyEvenDiffCheck.Font = new Font("メイリオ", 9F);
            m_OnlyEvenDiffCheck.Location = new Point(153, 84);
            m_OnlyEvenDiffCheck.Name = "m_OnlyEvenDiffCheck";
            m_OnlyEvenDiffCheck.Size = new Size(99, 22);
            m_OnlyEvenDiffCheck.TabIndex = 7;
            m_OnlyEvenDiffCheck.Text = "偶数ズレのみ";
            m_OnlyEvenDiffCheck.UseVisualStyleBackColor = true;
            // 
            // Gen4SeedInputSupportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 164);
            Controls.Add(m_OnlyEvenDiffCheck);
            Controls.Add(m_InputButton);
            Controls.Add(m_FrameDiffRangeBox);
            Controls.Add(label2);
            Controls.Add(m_SecondsDiffCheck);
            Controls.Add(m_InitialSeedBox);
            Controls.Add(label1);
            Name = "Gen4SeedInputSupportForm";
            Text = "第4世代入力補助";
            FormClosing += Gen4SeedInputSupportForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)m_FrameDiffRangeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox m_InitialSeedBox;
        private CheckBox m_SecondsDiffCheck;
        private Label label2;
        private NumericUpDown m_FrameDiffRangeBox;
        private Button m_InputButton;
        private CheckBox m_OnlyEvenDiffCheck;
    }
}