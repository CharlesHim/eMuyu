using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 电子木鱼
{
    public partial class Form1 : Form
    {
        int gongde = 0;
        SoundPlayer muyu = new SoundPlayer("muyu_short.wav");
        SoundPlayer lol = new SoundPlayer("god_lol.wav");

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gongde++;
            label3.Text = Convert.ToString("当前功德："+gongde);
            muyu.Load();
            muyu.PlaySync();
            muyu.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith("1"))
            {
                if (gongde > 0)
                {
                    textBox2.Text = "佛祖：";
                    while (gongde > 0)
                    {
                        textBox2.Text = textBox2.Text.Insert(textBox2.Text.Length, "哈");
                        gongde--;
                    }
                    label3.Text = Convert.ToString("当前功德：" + gongde);
                    lol.Load();
                    lol.Play();
                    lol.Dispose();
                }
                else
                {
                    textBox2.Text = "佛祖：你的功德不足！";
                }
            }
        }
    }
}
