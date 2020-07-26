using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TestApp4
{
    public partial class Form1 : Form
    {
        private readonly string appRoot = Environment.CurrentDirectory + @"\..\..\..\";
        private XmlNode root;
        private XmlDocument xmldoc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
            InitComponentXml();

            txtMsg.Text = "test: " + root.SelectNodes("ComponentArray").Item(1).Attributes.GetNamedItem("name").Value;
        }

        private void InitComponentXml()
        {
            xmldoc.Load(appRoot + @"\configs\ComponentManager.xml");
            root = xmldoc.SelectNodes("ComponentManager/Components").Item(0);
        }
    }
}
