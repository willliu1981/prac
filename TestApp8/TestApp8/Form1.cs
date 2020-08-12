using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            int a;

            ByRef(out a);

            txtMsg.Text = "a= " + a;

        }

        private void ByRef(out int ra)
        {
            ra = 2;
            ra++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
