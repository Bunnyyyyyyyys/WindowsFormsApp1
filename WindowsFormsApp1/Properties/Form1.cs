using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && comboBox1.Text != "")
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString() + ": " + comboBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > 0 && listBox2.SelectedItem != null)
            {
                int index = listBox2.SelectedIndex;
                string text = listBox2.SelectedItem.ToString();
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.Insert(index - 1, text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < listBox2.Items.Count - 1)
            {
                int index = listBox2.SelectedIndex;
                string text = listBox2.SelectedItem.ToString();
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.Insert(index + 1, text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
