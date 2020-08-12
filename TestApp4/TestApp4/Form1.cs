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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TestApp4
{
    public class Book
    {
        public string name;
        public string author;
    }
    public partial class Form1 : Form
    {
        private string xmlPath = @"configs\ComponentManager.xml";
        private XmlNode currentNode;
        private XmlDocument xmldoc = new XmlDocument();

        public static void WriteXML()
        {
            
            Book book1 = new Book();
            book1.name = "c#";
            book1.author = "Mary";
            Book book2 = new Book();
            book2.name = "java";
            book2.author = "David";
            XmlSerializer writer = new XmlSerializer(typeof(Book));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Book.xml";
            FileStream file = File.Create(path);
            Book[] books = new[] { book1, book2 };
            writer.Serialize(file, book1);
            file.Close();

        }

        public void changeXMLVal(int fstIndex,int secIndex,string element,string key,string value)
        {
            try
            {
                XmlNode node = currentNode.ChildNodes[fstIndex].ChildNodes[secIndex];
                if (node != null)
                {
                    node.Attributes.GetNamedItem(key).Value = value;
                }
                else
                {
                    XmlElement elem;
                    elem = xmldoc.CreateElement(element);
                    elem.SetAttribute(key,value);
                    currentNode.ChildNodes[fstIndex].AppendChild(elem);
                }
                xmldoc.Save(xmlPath);

            }catch(Exception ex)
            {
               Console.WriteLine(ex.StackTrace);
            }


        }

        public Form1()
        {
            InitializeComponent();
            InitConfigsXml();

            //WriteXML();
            changeXMLVal(0,0, "Component","id","88");


            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(@"<Component id=""4"" order =""4"" tag ="""" />");
            //XmlNode node = currentNode.SelectNodes("ComponentArray").Item(0);
            


            txtMsg.Text = "test: " + currentNode.SelectNodes("ComponentArray").Item(0).Attributes.GetNamedItem("name").Value;
            //txtMsg2.Text = "test: " +doc.ToString();
        }

        private void InitConfigsXml()
        {
            xmldoc.Load(xmlPath);
            currentNode = xmldoc.SelectNodes("ComponentManager/Components").Item(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
