using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抽奖程序_v._1._0._0a
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string optionBuffer = "";
        int optionCount = 0;
        List<string> options = new List<string>();
        private void button1_Click(object sender, EventArgs e)  //添加到列表
        {
            if (optionCount < 100)
            {
                options.Add(optionBuffer);
                optionCount++;
                listBox1.Items.Add(optionBuffer);
            }
            else
            {
                MessageBox.Show("太大了!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            optionBuffer = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)  //从列表删除
        {
            listBox1.Items.Clear();
            options.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)    //保存
        {
            saveFileDialog1 = new SaveFileDialog();
            string savePath = "";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog1.FileName;
                if(savePath == null)
                {
                    MessageBox.Show("路径错误");
                }
                else
                {
                    await File.WriteAllLinesAsync(savePath, options);
                    MessageBox.Show("保存成功!");
                }
            }
        }
    }
}
