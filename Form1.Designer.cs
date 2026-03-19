namespace EchoMessenger
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
            lblMain = new Label();
            txtMessageBox = new TextBox();
            lstMessageList = new ListBox();
            btnEnter = new Button();
            chkTimeStamp = new CheckBox();
            lblTimeStampHelp = new Label();
            lblMessageCount = new Label();
            lblAutoDelHelp = new Label();
            chkAutoDel = new CheckBox();
            btnDelSelected = new Button();
            lblDelSelectedHelp = new Label();
            lblDelAllHelp = new Label();
            btnDelAll = new Button();
            lblStrictCheckHelp = new Label();
            chkStrictCheck = new CheckBox();
            SuspendLayout();
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("궁서", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblMain.Location = new Point(12, 14);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(617, 64);
            lblMain.TabIndex = 0;
            lblMain.Text = "ECHO MESSENGER";
            // 
            // txtMessageBox
            // 
            txtMessageBox.BorderStyle = BorderStyle.FixedSingle;
            txtMessageBox.Font = new Font("한컴 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtMessageBox.Location = new Point(12, 501);
            txtMessageBox.Name = "txtMessageBox";
            txtMessageBox.Size = new Size(761, 49);
            txtMessageBox.TabIndex = 1;
            txtMessageBox.KeyDown += textBox1_KeyDown;
            // 
            // lstMessageList
            // 
            lstMessageList.Font = new Font("한컴 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstMessageList.FormattingEnabled = true;
            lstMessageList.Location = new Point(12, 97);
            lstMessageList.Name = "lstMessageList";
            lstMessageList.Size = new Size(761, 389);
            lstMessageList.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.White;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("한컴 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnEnter.Location = new Point(784, 501);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(116, 49);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += button1_Click;
            // 
            // chkTimeStamp
            // 
            chkTimeStamp.AutoSize = true;
            chkTimeStamp.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkTimeStamp.Location = new Point(779, 131);
            chkTimeStamp.Name = "chkTimeStamp";
            chkTimeStamp.Size = new Size(133, 29);
            chkTimeStamp.TabIndex = 4;
            chkTimeStamp.Text = "TimeStamp";
            chkTimeStamp.UseVisualStyleBackColor = true;
            // 
            // lblTimeStampHelp
            // 
            lblTimeStampHelp.AutoSize = true;
            lblTimeStampHelp.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTimeStampHelp.Location = new Point(774, 158);
            lblTimeStampHelp.Name = "lblTimeStampHelp";
            lblTimeStampHelp.Size = new Size(98, 16);
            lblTimeStampHelp.TabIndex = 5;
            lblTimeStampHelp.Text = "타임스탬프 도움말";
            // 
            // lblMessageCount
            // 
            lblMessageCount.AutoSize = true;
            lblMessageCount.BackColor = Color.FromArgb(255, 255, 192);
            lblMessageCount.FlatStyle = FlatStyle.Flat;
            lblMessageCount.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblMessageCount.Location = new Point(779, 97);
            lblMessageCount.Name = "lblMessageCount";
            lblMessageCount.Size = new Size(120, 21);
            lblMessageCount.TabIndex = 6;
            lblMessageCount.Text = "대화 횟수 : 00개";
            // 
            // lblAutoDelHelp
            // 
            lblAutoDelHelp.AutoSize = true;
            lblAutoDelHelp.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAutoDelHelp.Location = new Point(774, 210);
            lblAutoDelHelp.Name = "lblAutoDelHelp";
            lblAutoDelHelp.Size = new Size(87, 16);
            lblAutoDelHelp.TabIndex = 8;
            lblAutoDelHelp.Text = "자동삭제 도움말";
            // 
            // chkAutoDel
            // 
            chkAutoDel.AutoSize = true;
            chkAutoDel.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkAutoDel.Location = new Point(779, 183);
            chkAutoDel.Name = "chkAutoDel";
            chkAutoDel.Size = new Size(131, 29);
            chkAutoDel.TabIndex = 7;
            chkAutoDel.Text = "AutoDelete";
            chkAutoDel.UseVisualStyleBackColor = true;
            // 
            // btnDelSelected
            // 
            btnDelSelected.BackColor = Color.White;
            btnDelSelected.FlatStyle = FlatStyle.Flat;
            btnDelSelected.Font = new Font("한컴 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelSelected.Location = new Point(779, 375);
            btnDelSelected.Name = "btnDelSelected";
            btnDelSelected.Size = new Size(121, 32);
            btnDelSelected.TabIndex = 9;
            btnDelSelected.Text = "선택 대화 삭제";
            btnDelSelected.UseVisualStyleBackColor = false;
            btnDelSelected.Click += btnDelSelected_Click;
            // 
            // lblDelSelectedHelp
            // 
            lblDelSelectedHelp.AutoSize = true;
            lblDelSelectedHelp.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblDelSelectedHelp.Location = new Point(779, 410);
            lblDelSelectedHelp.Name = "lblDelSelectedHelp";
            lblDelSelectedHelp.Size = new Size(109, 16);
            lblDelSelectedHelp.TabIndex = 10;
            lblDelSelectedHelp.Text = "선택대화삭제 도움말";
            // 
            // lblDelAllHelp
            // 
            lblDelAllHelp.AutoSize = true;
            lblDelAllHelp.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblDelAllHelp.Location = new Point(779, 467);
            lblDelAllHelp.Name = "lblDelAllHelp";
            lblDelAllHelp.Size = new Size(109, 16);
            lblDelAllHelp.TabIndex = 12;
            lblDelAllHelp.Text = "모든대화삭제 도움말";
            // 
            // btnDelAll
            // 
            btnDelAll.BackColor = Color.White;
            btnDelAll.FlatStyle = FlatStyle.Flat;
            btnDelAll.Font = new Font("한컴 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelAll.Location = new Point(779, 432);
            btnDelAll.Name = "btnDelAll";
            btnDelAll.Size = new Size(121, 32);
            btnDelAll.TabIndex = 11;
            btnDelAll.Text = "모든 대화 삭제";
            btnDelAll.UseVisualStyleBackColor = false;
            btnDelAll.Click += btnDelAll_Click;
            // 
            // lblStrictCheckHelp
            // 
            lblStrictCheckHelp.AutoSize = true;
            lblStrictCheckHelp.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblStrictCheckHelp.Location = new Point(774, 282);
            lblStrictCheckHelp.Name = "lblStrictCheckHelp";
            lblStrictCheckHelp.Size = new Size(98, 16);
            lblStrictCheckHelp.TabIndex = 14;
            lblStrictCheckHelp.Text = "문자열체크 도움말";
            // chkStrictCheck
            // 
            chkStrictCheck.AutoSize = true;
            chkStrictCheck.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkStrictCheck.Location = new Point(779, 255);
            chkStrictCheck.Name = "chkStrictCheck";
            chkStrictCheck.Size = new Size(130, 29);
            chkStrictCheck.TabIndex = 13;
            chkStrictCheck.Text = "StrictCheck";
            chkStrictCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(912, 562);
            Controls.Add(lblStrictCheckHelp);
            Controls.Add(chkStrictCheck);
            Controls.Add(lblDelAllHelp);
            Controls.Add(btnDelAll);
            Controls.Add(lblDelSelectedHelp);
            Controls.Add(btnDelSelected);
            Controls.Add(lblAutoDelHelp);
            Controls.Add(chkAutoDel);
            Controls.Add(lblMessageCount);
            Controls.Add(lblTimeStampHelp);
            Controls.Add(chkTimeStamp);
            Controls.Add(btnEnter);
            Controls.Add(lstMessageList);
            Controls.Add(txtMessageBox);
            Controls.Add(lblMain);
            Name = "Form1";
            Text = "Echo Messenger";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMain;
        private TextBox txtMessageBox;
        private ListBox lstMessageList;
        private Button btnEnter;
        private CheckBox chkTimeStamp;
        private Label lblTimeStampHelp;
        private Label lblMessageCount;
        private Label lblAutoDelHelp;
        private CheckBox chkAutoDel;
        private Button btnDelSelected;
        private Label lblDelSelectedHelp;
        private Label lblDelAllHelp;
        private Button btnDelAll;
        private Label lblStrictCheckHelp;
        private CheckBox chkStrictCheck;
    }
}
