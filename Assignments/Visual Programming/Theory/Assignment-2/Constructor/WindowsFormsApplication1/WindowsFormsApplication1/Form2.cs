using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private string passedData;
        public Form2(string data)
        {
            InitializeComponent();
            passedData = data;
            label1.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.tb1.Text = "set by form2";
        }
    }
}