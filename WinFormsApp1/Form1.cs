using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您點的是：" + textBox1.Text, "點餐資訊", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("您已取消點餐！", "點餐資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            order(textBox1.Text, result);
        }


        private void order(string food, DialogResult result)
        {
            switch (textBox1.Text)
            {
                case "漢堡":
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("漢堡賣完了，要不要試試薯條？", "點餐資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "":
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("請輸入餐點名稱！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("好的，正在為您準備" + textBox1.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
