using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp6
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CA c = new CB();
            txtMsg.Text = "test: " + c.GetMsg("David");
        }
    }

     class CA
    {
        public virtual String GetMsg(String name)
        {
            return "name " + name;
        }

    }

    class CB : CA
    {

        public new virtual String GetMsg(String name)
        {
            return "your name is " + name;
        }
    }

    class CC : CB
    {
        public override String GetMsg(String name)
        {
            return "Hello ," + name;
        }
    }



}
