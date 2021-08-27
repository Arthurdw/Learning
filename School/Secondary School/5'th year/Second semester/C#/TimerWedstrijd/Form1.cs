using System;
using System.Collections;
using System.Windows.Forms;

namespace TimerWedstrijd
{
    public partial class Form1 : Form
    {
        public int timer;
        public int counter;
        public bool stop;
        public DateTime startTime;
        public String[] initial;
        public Array data;
        Form latest;

        public Form1()
        {
            InitializeComponent();
            this.initial = new String[] { label1.Text, label2.Text, label3.Text, label4.Text, label5.Text };
            button6.Enabled = textBox1.Enabled = false;
            Init();
        }

        private void Init()
        {
            this.timer = 0;
            this.counter = 0;
            this.stop = false;
            btnStart.Text = "START";
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.stop) disable();
            else start();
        }

        private void start()
        {
            startTime = DateTime.UtcNow;
            timer1.Start();
            btnStart.Text = "STOP";
            this.stop = true;
            this.data = new Array[5];
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = true;
            label1.Text = this.initial[0];
            label2.Text = this.initial[1];
            label3.Text = this.initial[2];
            label4.Text = this.initial[3];
            label5.Text = this.initial[4];
            button6.Enabled = textBox1.Enabled = false;
        }

        private void disable()
        {
            timer1.Stop();
            Init();
            button6.Enabled = textBox1.Enabled = true;
            textBox1.Select();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = $"{DateTime.UtcNow.ToString("HH:mm:ss.ff")}\t{this.timer}";
            this.timer++;
        }
        private void AddArrived(Button btn, Label lbl, string str)
        {
            this.counter++;
            lbl.Text = $"{this.counter} - {str}";
            btn.Enabled = false;
            if (this.counter == 5) disable();
            ArrayList sub_data = new ArrayList();
            sub_data.Add(lbl.Text);
            sub_data.Add(DateTime.UtcNow - this.startTime);
            sub_data.Add(btn.BackgroundImage);
            data.SetValue(sub_data.ToArray(), counter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddArrived(button1, label1, DateTime.UtcNow.ToString("HH:mm:ss.ff"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddArrived(button2, label2, DateTime.UtcNow.ToString("HH:mm:ss.ff"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddArrived(button3, label3, DateTime.UtcNow.ToString("HH:mm:ss.ff"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddArrived(button4, label4, DateTime.UtcNow.ToString("HH:mm:ss.ff"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddArrived(button5, label5, DateTime.UtcNow.ToString("HH:mm:ss.ff"));
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (this.latest != null) this.latest.Close();
            this.latest = new Form2(data);
            this.latest.Show();
        }
    }
}
