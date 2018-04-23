using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaJednoKierunkowa
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Element
        {
            public Element Next { get; set; }
            public String Value { get; set; }

            public Element(String value)
            {
                Value = value;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Element root = new Element("root");
            Element first = new Element("1st");
            root.Next = first;
            Element second = new Element("2nd");
            first.Next = second;
            Element third = new Element("3rd");
            second.Next = third;
            Element fourth = new Element("4th");
            third.Next = fourth;
            // Output
            Element element = root;
            while (element != null)
            {
                MessageBox.Show(element.Value.ToString());
                element = element.Next;
            }

        }

        

        

    private void btnListJedno_Click(object sender, EventArgs e)
        {

                





        }
    }
}
