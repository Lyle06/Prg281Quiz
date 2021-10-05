using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prg281Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string path = @"People.txt";
            if (File.Exists(path)) {

                using (TextReader reader= File.OpenText(path)) {

                    listBox1.Items.Add(reader.ReadToEnd());
                }
            }
        }
    }
}
