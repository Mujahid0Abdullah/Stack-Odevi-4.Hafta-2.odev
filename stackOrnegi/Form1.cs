using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stackOrnegi
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //  Stack<string> stack= new Stack<string>();
        stack1 stack = new stack1();


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPush.Text != "")
            {
                stack.koy(textBoxPush.Text);
                // listBox1.Items.Insert(0, stack.s[stack.top]);
                listBox1.Items.Insert(0, stack.getust());
                textBoxPush.Clear();
                //print();
                if (listBox1.Items.Count != 0)
                {
                    button_pop.Enabled = true;
                    textBoxpop.Text = stack.getust();
                }
                textBoxPush.Focus();
            }
            if (max_size == stack.len)
            {
                button_push.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxpop.Clear();
            textBoxpop.Text = stack.getust();
           
            stack.al();

            //textBoxpop.Text = stack.ust();

            if (button_push.Enabled == false)
            {
                button_push.Enabled = true;
            }
            //int t = stack.top;
            if (listBox1.Items.Count == 1)
            {
                textBoxpop.Clear();
                button_pop.Enabled = false;
            }
            listBox1.Items.RemoveAt(0);
          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int max_size; 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            max_size = (Int32)numericUpDown1.Value;
        }

        private void textBoxpop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
