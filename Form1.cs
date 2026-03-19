using System.Collections.Generic;
using System.Drawing;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<Control, Point> _baseLocations = new();
        private Size _baseClientSize;

        public Form1()
        {
            InitializeComponent();

            chkTimeStamp.Checked = true;

            updateResults();

            CaptureBaseLayout();
            CenterLayout();
            Resize += (_, _) => CenterLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimeStampHelp.Text = "자동으로 타임스탬프 추가";
            lblAutoDelHelp.Text = "메시지가 10개를 넘으면\n오래된 메시지를 삭제";
            lblDelSelectedHelp.Text = "선택한 메시지를 삭제";
            lblDelAllHelp.Text = "모든 메시지를 삭제";
            lblStrictCheckHelp.Text = "한글, 영어, 숫자로\n메시지를 제한";
        }

        private void CaptureBaseLayout()
        {
            _baseClientSize = ClientSize;
            _baseLocations.Clear();

            foreach (Control c in Controls)
            {
                _baseLocations[c] = c.Location;
            }
        }

        private void CenterLayout()
        {
            if (_baseLocations.Count == 0)
            {
                return;
            }

            var dx = (ClientSize.Width - _baseClientSize.Width) / 2;
            var dy = (ClientSize.Height - _baseClientSize.Height) / 2;

            SuspendLayout();
            try
            {
                foreach (var kvp in _baseLocations)
                {
                    kvp.Key.Location = new Point(kvp.Value.X + dx, kvp.Value.Y + dy);
                }
            }
            finally
            {
                ResumeLayout();
            }
        }

        private string addTimeStamp(string message)
        {
            string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return $"[{timeStamp}] {message}";
        } // 타임스탬프 추가 메서드

        private void updateResults()
        {
            if (chkAutoDel.Checked == true)
            {
                while (lstMessageList.Items.Count > 10)
                {
                    lstMessageList.Items.RemoveAt(0);
                }
            } // 오래된 메시지 삭제

            if (lstMessageList.Items.Count == 0)
            {
                lblMessageCount.Text = "대화 횟수 : 없음";
                return;
            }
            else if (lstMessageList.Items.Count > 99)
            {
                lblMessageCount.Text = "대화 횟수 : 99+";
                return;
            }
            else if (lstMessageList.Items.Count < 10)
            {
                lblMessageCount.Text = $"대화 횟수 : 0{lstMessageList.Items.Count}개";
                return;
            }
            else
            {
                lblMessageCount.Text = $"대화 횟수 : {lstMessageList.Items.Count}개";
            } // 대화 횟수 업데이트

        } // 메시지 정리

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typedMessage;

            if (string.IsNullOrWhiteSpace(txtMessageBox.Text))
            {
                txtMessageBox.Text = "메시지를 입력해주세요.";
                txtMessageBox.SelectAll();
                txtMessageBox.Focus();

            }
            else
            {
                typedMessage = txtMessageBox.Text;

                typedMessage.Trim();

                if (chkStrictCheck.Checked)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(typedMessage, @"^[a-zA-Z0-9가-힣\s]+$"))
                    {
                        MessageBox.Show("메시지는 한글, 영어, 숫자만 입력 가능합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMessageBox.SelectAll();
                        txtMessageBox.Focus();
                        return;
                    } // 한글 영어 숫자만 가능하게
                }

                if (typedMessage.Length > 30)
                {
                    MessageBox.Show("메시지는 최대 30자까지 입력 가능합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMessageBox.SelectAll();
                    txtMessageBox.Focus();
                    return;
                }

                if (typedMessage == "메시지를 입력해주세요.")
                {
                    txtMessageBox.SelectAll();
                    txtMessageBox.Focus();
                    return;
                } // 메시지를 입력해주세요면 입력 안 되게

                if (chkTimeStamp.Checked)
                {
                    typedMessage = addTimeStamp(typedMessage);
                } // 타임스탬프가 체크되었다면 타임스탬프 추가


                lstMessageList.Items.Add(typedMessage);

                txtMessageBox.Clear();
                txtMessageBox.Focus();

                updateResults();
            }
        }

        private void btnDelSelected_Click(object sender, EventArgs e)
        {
            if (lstMessageList.SelectedIndex == -1)
            {
                MessageBox.Show("삭제할 메시지를 선택해주세요.", "선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstMessageList.Items.RemoveAt(lstMessageList.SelectedIndex);
            updateResults();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lstMessageList.Items.Clear();
            updateResults();
        }
    }
}
