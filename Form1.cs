namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkBox1.Checked = true;

            updateResults();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "자동으로 타임스탬프를\n추가할지 선택합니다";
        }

        private string addTimeStamp(string message)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return $"[{timeStamp}] {message}";
        } // 타임스탬프 추가 메서드

        private void updateResults()
        {
            if (listBox1.Items.Count == 0)
            {
                label3.Text = "대화 횟수 : 없음";
                return;
            }
            else if (listBox1.Items.Count > 99)
            {
                label3.Text = "대화 횟수 : 99+";
                return;
            }
            else if (listBox1.Items.Count < 10)
            {
                label3.Text = $"대화 횟수 : 0{listBox1.Items.Count}개";
                return;
            }
            else
            {
                label3.Text = $"대화 횟수 : {listBox1.Items.Count}개";
            }
        } // 메시지 정리

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typedMessage;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "메시지를 입력해주세요.";
                textBox1.SelectAll();
                textBox1.Focus();

            }
            else
            {
                typedMessage = textBox1.Text;

                typedMessage.Trim();

                if (typedMessage == "메시지를 입력해주세요.")
                {
                    textBox1.SelectAll();
                    textBox1.Focus();
                    return;
                } // 메시지를 입력해주세요면 입력 안 되게

                if (checkBox1.Checked)
                {
                    typedMessage = addTimeStamp(typedMessage);
                } // 타임스탬프가 체크되었다면 타임스탬프 추가
                

                listBox1.Items.Add(typedMessage);

                textBox1.Clear();
                textBox1.Focus();

                updateResults();
            }
        }
    }
}
