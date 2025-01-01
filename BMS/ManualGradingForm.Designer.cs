namespace BMS
{
    partial class ManualGradingForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            datagridGradeProgressList = new DataGridView();
            tabPage2 = new TabPage();
            btSave = new Button();
            datagridAnswer = new DataGridView();
            panel3 = new Panel();
            numScore = new NumericUpDown();
            txtScoringRubric = new TextBox();
            label6 = new Label();
            txtNote = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            txtAnswer = new TextBox();
            txtQuestion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridGradeProgressList).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridAnswer).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScore).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1472, 1209);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(datagridGradeProgressList);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1456, 1155);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "시험 제출 목록";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(512, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(401, 39);
            txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 1;
            label1.Text = "응시 ID";
            // 
            // datagridGradeProgressList
            // 
            datagridGradeProgressList.AllowUserToAddRows = false;
            datagridGradeProgressList.AllowUserToDeleteRows = false;
            datagridGradeProgressList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridGradeProgressList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridGradeProgressList.Location = new Point(3, 65);
            datagridGradeProgressList.Name = "datagridGradeProgressList";
            datagridGradeProgressList.ReadOnly = true;
            datagridGradeProgressList.RowHeadersWidth = 82;
            datagridGradeProgressList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridGradeProgressList.Size = new Size(1450, 1087);
            datagridGradeProgressList.TabIndex = 0;
            datagridGradeProgressList.CellDoubleClick += datagridGradeProgressList_CellDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btSave);
            tabPage2.Controls.Add(datagridAnswer);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1456, 1155);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "채점 진행";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Location = new Point(1278, 1103);
            btSave.Name = "btSave";
            btSave.Size = new Size(150, 46);
            btSave.TabIndex = 4;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // datagridAnswer
            // 
            datagridAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridAnswer.Location = new Point(6, 6);
            datagridAnswer.Name = "datagridAnswer";
            datagridAnswer.RowHeadersWidth = 82;
            datagridAnswer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridAnswer.Size = new Size(477, 1080);
            datagridAnswer.TabIndex = 0;
            datagridAnswer.SelectionChanged += datagridAnswer_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(numScore);
            panel3.Controls.Add(txtScoringRubric);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtNote);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(492, 479);
            panel3.Name = "panel3";
            panel3.Size = new Size(958, 607);
            panel3.TabIndex = 2;
            // 
            // numScore
            // 
            numScore.Location = new Point(104, 354);
            numScore.Name = "numScore";
            numScore.Size = new Size(240, 39);
            numScore.TabIndex = 6;
            // 
            // txtScoringRubric
            // 
            txtScoringRubric.Location = new Point(26, 52);
            txtScoringRubric.Multiline = true;
            txtScoringRubric.Name = "txtScoringRubric";
            txtScoringRubric.Size = new Size(910, 293);
            txtScoringRubric.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 422);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 4;
            label6.Text = "메모";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(104, 419);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(832, 170);
            txtNote.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 354);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 1;
            label5.Text = "점수";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 17);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 0;
            label4.Text = "채점 기준";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(txtAnswer);
            panel2.Controls.Add(txtQuestion);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(492, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 467);
            panel2.TabIndex = 1;
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.Location = new Point(26, 279);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.ScrollBars = ScrollBars.Vertical;
            txtAnswer.Size = new Size(910, 173);
            txtAnswer.TabIndex = 7;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(25, 49);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ReadOnly = true;
            txtQuestion.Size = new Size(911, 192);
            txtQuestion.TabIndex = 6;
            txtQuestion.Text = "제1차 세계 대전의 주요 원인과 전쟁의 결과에 대해 설명하시오.\n답변은 주요 원인 3가지와 전쟁 결과 2가지를 포함하여 작성하시오. (배점: 20점)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 14);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 1;
            label3.Text = "지문";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 244);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 0;
            label2.Text = "제출 답안";
            // 
            // ManualGradingForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "ManualGradingForm";
            Size = new Size(1472, 1209);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridGradeProgressList).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridAnswer).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numScore).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView datagridGradeProgressList;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView datagridAnswer;
        private Label label6;
        private TextBox txtNote;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btSave;
        private TextBox txtScoringRubric;
        private TextBox txtAnswer;
        private TextBox txtQuestion;
        private NumericUpDown numScore;
    }
}
