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

namespace knjiznica2
{
    public partial class Form1 : Form
    {
        private string contents;

        public object UsersÎnik { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            using (StreamReader streamReader = new StreamReader("C: \Users\ucenik\Downloads", Encoding.UTF8))
            {
                contents = streamReader.ReadToEnd();
            }
            doc.LoadXml(contents);
        }
    }
}
