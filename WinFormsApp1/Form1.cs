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
            DialogResult result = MessageBox.Show("Yes", "NO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("You clicked OK!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You clicked Cancel!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Cancel:
                    MessageBox.Show("You clicked Cancel!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.TryAgain:
                    MessageBox.Show("You clicked Try Again!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.Continue:
                    MessageBox.Show("You clicked Continue!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
