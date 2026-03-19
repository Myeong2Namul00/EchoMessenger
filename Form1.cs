namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typedMessage;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "메시지를 입력해주세요.";

            }
            else
            {
                typedMessage = textBox1.Text;
                listBox1.Items.Add(typedMessage);
            }
        }
    }
}
