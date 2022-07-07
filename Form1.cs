namespace 抽奖程序_v._1._0._0a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 打开创建向导ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        string[] options;
        private void 从文件夹打开ToolStripMenuItem_Click(object sender, EventArgs e)      //开始抽奖
        {
            openFileDialog1 = new OpenFileDialog();
            string path;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                string txt = System.IO.File.ReadAllText(path);
                options = txt.Split('\n');
                label1.Text = "已读取,按开始按钮开始抽奖";
            }
        }

        private void startBotten_Click(object sender, EventArgs e)
        {
            if (label1.Text == "欢迎使用")
            {
                MessageBox.Show("错误,未打开选项");
            } else
            {
                var rand = new Random();
                label1.Text = options[rand.Next(0, options.Length - 1)];
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)   //help按键
        {
            MessageBox.Show("想屁吃");
        }
    }
}