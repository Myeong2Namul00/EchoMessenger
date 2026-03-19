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
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("궁서", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(617, 64);
            label1.TabIndex = 0;
            label1.Text = "ECHO MESSENGER";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("한컴 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(12, 501);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(761, 49);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("한컴 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(761, 389);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("한컴 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(784, 501);
            button1.Name = "button1";
            button1.Size = new Size(116, 49);
            button1.TabIndex = 3;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("한컴 고딕", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            checkBox1.Location = new Point(779, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "TimeStamp";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("한컴 고딕", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(779, 124);
            label2.Name = "label2";
            label2.Size = new Size(98, 16);
            label2.TabIndex = 5;
            label2.Text = "타임스탬프 도움말";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("한컴 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(781, 469);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 6;
            label3.Text = "대화 횟수 : 00개";
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(912, 562);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Echo Messenger";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
    }
}
