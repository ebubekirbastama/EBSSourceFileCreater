using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Source_file_creater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EBSOkuyucuveYazici.EBSresxYazText(Application.StartupPath + @"//EBS.resx",richTextBox1,"Veri");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EBSOkuyucuveYazici.op = new OpenFileDialog();
            if (EBSOkuyucuveYazici.op.ShowDialog() == DialogResult.OK)
            {
                EBSOkuyucuveYazici.EBSresxYazİmage(Application.StartupPath + @"//EBS.resx",EBSOkuyucuveYazici.op.FileName,pictureBox1,"İmage");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EBSOkuyucuveYazici.EBSresxokuText(Application.StartupPath + @"//EBS.resx",richTextBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EBSOkuyucuveYazici.EBSresxokuİmage(Application.StartupPath + @"//EBS.resx",pictureBox1);
        }
    }
}
