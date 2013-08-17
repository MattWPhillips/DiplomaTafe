using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(77);
            linkedList.add(10);
            linkedList.add(20);
            linkedList.add(5);
            linkedList.add(432);
            linkedList.add(2);
            linkedList.add(9);

            linkedList.DisplayAllNodes();
        }
    }
}
