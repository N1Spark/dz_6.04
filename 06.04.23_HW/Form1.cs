using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06._04._23_HW
{
    public partial class Form1 : Form
    {
        static int score = 0;
        static int timer = 0;
        static int timer_2 = 5;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            groupBox4.Text = "4. Абоба?";
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            label1.Text = "Осталось " + timer_2 + " сек";
            label1.Visible = true;
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = false;
            if (radioButton2.Checked)
                score += 5;
            if (radioButton5.Checked)
                score += 5;
            if (radioButton10.Checked)
                score += 10;
            if (radioButton11.Checked)
                score += 10;
            if(radioButton14.Checked)
                score += 10;
            if(radioButton16.Checked)
                score += 10;
            if (radioButton18.Checked)
                score += 10;
            if(checkBox2.Checked && checkBox3.Checked)
                score += 15;
            if(checkBox5.Checked && checkBox6.Checked)
                score += 15;
            progressBar1.Value = score;
            progressBar1.Visible = true;
            string temp3 = score.ToString() + "%";
            label3.Text = temp3;
            label3.Visible = true;
            label2.Visible = true;
            Text = "Прошло " + timer + " сек";
            string temp = "user";
            int num = 1;
            string file = File.ReadAllText("result.txt");
            while (true)
            {
                if (!file.Contains(temp + num))
                {
                    StreamWriter sw = new StreamWriter("result.txt");
                    sw.Write(file);
                    sw.WriteLine(temp + num + " - " + score + " баллов за " + timer + " сек");
                    sw.Close();
                    break;
                }
                else
                    num++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(timer_2 == 0)
            {
                radioButton6.Enabled = false;
                radioButton7.Enabled = false;
                timer2.Stop();
            }
            else
            {
                timer_2--;
                label1.Text = "Осталось " + timer_2 + " сек";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }
    }
}
