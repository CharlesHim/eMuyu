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
        int rps = 1;
        int fish = 1;
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
            label3.Text = Convert.ToString("当前功德：" + gongde);
            label11.Text = Convert.ToString("当前功德：" + gongde);
            label6.Text = Convert.ToString("当前功德：" + gongde);
            muyu.Load();
            muyu.PlaySync();
            muyu.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = false;   //先停下来，要不然佛祖笑不出来
            radioButton6.Checked = false;
            radioButton4.Checked = true;
            radioButton5.Checked = true;

            if (textBox1.Text.EndsWith("1"))
            {
                if (gongde > 0)
                {
                    textBox2.Text = "佛祖：";
                    int loop = Math.Min(122,gongde);
                    while (loop > 0)
                    {
                        textBox2.Text = textBox2.Text.Insert(textBox2.Text.Length, "哈");
                        loop--;
                    }
                    gongde = 0;
                    label3.Text = Convert.ToString("当前功德：" + gongde);
                    label11.Text = Convert.ToString("当前功德：" + gongde);
                    label6.Text = Convert.ToString("当前功德：" + gongde);
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                radioButton6.Checked = false;
                radioButton5.Checked = true;

            }
            else if (radioButton2.Checked && radioButton6.Checked == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                radioButton3.Checked = false;
                radioButton4.Checked = true;

            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                radioButton6.Checked = false;
                radioButton5.Checked = true;

            }
            else if (radioButton2.Checked && radioButton6.Checked == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                radioButton3.Checked = false;
                radioButton4.Checked = true;

            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                radioButton6.Checked = false;
                radioButton5.Checked = true;

            }
            else if (radioButton2.Checked && radioButton6.Checked == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                radioButton3.Checked = false;
                radioButton4.Checked = true;

            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                radioButton6.Checked = false;
                radioButton5.Checked = true;

            }
            else if (radioButton2.Checked && radioButton6.Checked == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                radioButton3.Checked = false;
                radioButton4.Checked = true;

            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                radioButton6.Checked = false;
                radioButton5.Checked = true;

            }
            else if (radioButton2.Checked && radioButton6.Checked == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                radioButton3.Checked = false;
                radioButton4.Checked = true;

            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                radioButton6.Checked = false;
                radioButton5.Checked = true;

            }
            else if (radioButton2.Checked && radioButton6.Checked == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                radioButton3.Checked = false;
                radioButton4.Checked = true;

            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gongde++;
            label3.Text = Convert.ToString("当前功德：" + gongde);
            label11.Text = Convert.ToString("当前功德：" + gongde);
            label6.Text = Convert.ToString("当前功德：" + gongde);
            muyu.Load();
            muyu.PlaySync();
            muyu.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString("当前功德：" + gongde);
            label11.Text = Convert.ToString("当前功德：" + gongde);
            label6.Text = Convert.ToString("当前功德：" + gongde);
            label10.Text = Convert.ToString("转速：" + rps + " rps");
            label13.Text = Convert.ToString("鱼的数量：" + fish);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rps < 1)
                rps = 1;
            if (fish < 1)
                fish = 1;
            label10.Text = Convert.ToString("转速：" + rps + " rps");
            label13.Text = Convert.ToString("鱼的数量：" + fish);
            gongde = gongde + rps * fish;
            label3.Text = Convert.ToString("当前功德：" + gongde);
            label11.Text = Convert.ToString("当前功德：" + gongde);
            label6.Text = Convert.ToString("当前功德：" + gongde);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rps--;
            label10.Text = Convert.ToString("转速：" + rps + " rps");
            label13.Text = Convert.ToString("鱼的数量：" + fish);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rps++;
            label10.Text = Convert.ToString("转速：" + rps + " rps");
            label13.Text = Convert.ToString("鱼的数量：" + fish);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fish--;
            label10.Text = Convert.ToString("转速：" + rps + " rps");
            label13.Text = Convert.ToString("鱼的数量：" + fish);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fish++;
            label10.Text = Convert.ToString("转速：" + rps + " rps");
            label13.Text = Convert.ToString("鱼的数量：" + fish);
        }
    }
}
