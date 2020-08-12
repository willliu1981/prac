using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp7
{
    public partial class Form1 : Form
    {
        private Label[] balls;
        private bool isClick;
        private int ballClickIndex;
        public Form1()
        {
            InitializeComponent();
            ComponentManager.SetXml("config.xml");
            balls = ComponentManager.CreateComponentArray<Label>(panel1, "ball");

            for (int i = 0; i < balls.Length; i++)
            {
                balls[i].Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {
            if (!isClick)
            {
                timer1.Start();
                isClick = true;
                ballClickIndex = (int)((sender as Control).Tag as ComponentTag).Order;
                for (int i = 0; i < balls.Length; i++)
                {
                    balls[i].Enabled = i == ballClickIndex;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblCreate.Text = rnd.Next(1, 50).ToString();

        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            if (isClick)
            {
                timer1.Stop();
                balls[ballClickIndex].Text = (sender as Label).Text;
                isClick = false;
                foreach(Label L in balls)
                {
                    L.Enabled = true;
                }
            }
        }
    }
}
